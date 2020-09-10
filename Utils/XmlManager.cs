using Multi_Launcher_V2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Multi_Launcher_V2.Utils {
    class XmlManager {

        private static string Filename = "settings.xml";
        private static XmlModel xmlModel;

        public static XmlModel XmlModel {
            get {
                if (xmlModel == null)
                    xmlModel = ReadFromFile();
                return xmlModel;
            }
        }

        public static void ResetSettings() {
            var model = new XmlModel();
            model.Categories = buildSampleCategories();

            SaveToFile(model);
        }

        private static List<Category> buildSampleCategories() {
            var categories = new List<Category>();

            var itemsDictionary = new Dictionary<string, List<string>> {
                { "Jeux", new List<string> { "FIFA 20", "RDR2" } },
                { "Programmation", new List<string> { "IntelliJ", "Visual Studio" } },
                { "Entretien PC", new List<string> { "CPU-Z", "MSI Afterburner" } },
                { "Autre", new List<string>() }
            };

            foreach (KeyValuePair<string, List<string>> entry in itemsDictionary) {

                var category = new Category();
                category.Id = 0;
                category.Name = entry.Key;

                for (int i = 0; i < entry.Value.Count; i++) {

                    var item = new Item();
                    item.Id = i;
                    item.Name = entry.Value[i];
                    item.Target = "";
                    item.Category = category;
                    category.Items.Add(item);
                }

                categories.Add(category);
            }

            return categories;
        }

        public static Settings GetSettings() {
            return XmlModel.Settings;
        }

        public static void SaveSettings(Settings settings) {
            XmlModel.Settings = settings;
            SaveToFile(XmlModel);
        }

        public static List<Category> GetCategories() {
            return XmlModel.Categories;
        }

        public static void SaveCategories(List<Category> categories) {
            XmlModel.Categories = categories;
            SaveToFile(XmlModel);
        }


        private static void SaveToFile(XmlModel item) {

            var xs = new XmlSerializer(typeof(XmlModel));

            using (StreamWriter wr = new StreamWriter(Filename)) {
                xs.Serialize(wr, item);
            }
        }

        private static XmlModel ReadFromFile() {
            if (!File.Exists(Filename)) {
                return new XmlModel();
            }

            var xs = new XmlSerializer(typeof(XmlModel));

            using (StreamReader rd = new StreamReader(Filename)) {
                try {
                    var model = xs.Deserialize(rd) as XmlModel;
                    //model.Categories = model.Categories;
                    return model;
                }
                catch (InvalidOperationException e) {
                    Console.WriteLine("Unable to read configuration file " + e);
                    return new XmlModel();
                }
            }
        }
    }
}

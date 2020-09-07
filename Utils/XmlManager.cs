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
            SaveToFile(new XmlModel());
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

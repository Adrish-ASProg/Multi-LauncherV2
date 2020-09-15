using System.Collections.Generic;

namespace Multi_Launcher_V2.Model {
    public class XmlModel {

        public Settings Settings { get; set; }

        public List<Category> Categories { get; set; }

        public XmlModel() {
            Categories = new List<Category>();
            Settings = new Settings();
        }
    }
}

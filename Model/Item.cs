
using System.Drawing;
using System.Xml.Serialization;

namespace Multi_Launcher_V2.Model
{
    public class Item
    {
        public Item() { }

        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Target { get; set; }

        [XmlAttribute]
        public string ImageId { get; set; }

        [XmlIgnore]
        public Category Category { get; set; }

        [XmlIgnore]
        public Image Image { get; set; }
    }
}

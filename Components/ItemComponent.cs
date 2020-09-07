using Multi_Launcher_V2.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Multi_Launcher_V2 {
    public partial class ItemComponent : UserControl {

        private Item item;
        private Settings settings;

        public ItemComponent(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }

        public ItemComponent(Item item, Settings settings) {
            InitializeComponent();

            this.item = item;
            this.settings = settings;

            InitializeUI();
        }

        private void InitializeUI() {
            pictureItem.Tag = item.Name;
            pictureItem.Image = item.Image;
            pictureItem.SetBounds(0, 0, settings.imgSize, settings.imgSize);

            labelItem.Text = item.Name;
            labelItem.Visible = settings.names;

            SetBounds(0, 0, settings.imgSize, settings.imgSize + labelItem.Height + 5);
        }

        public void setOnPictureClicked(Action<Item> eventHandler) {
            pictureItem.Click += (s, e) => eventHandler.Invoke(item);
        }

        public void setOnMouseEnter(EventHandler eventHandler) {
            pictureItem.MouseEnter += eventHandler;
        }

        public void setOnMouseLeave(EventHandler eventHandler) {
            pictureItem.MouseLeave += eventHandler;
        }
    }
}

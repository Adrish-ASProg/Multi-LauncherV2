using Multi_Launcher_V2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Multi_Launcher_V2.Model;
using Multi_Launcher_V2.Utils;

namespace Multi_Launcher_V2 {
    public partial class ItemForm : Form {
        public Item item = new Item();
        public Image image;

        private List<Category> categories;

        public static Item ShowAddItemDialog(Form parent, List<Category> categories, int selectedCategoryIndex) {

            if (categories == null || categories.Count <= 0) {
                MessageBox.Show("Vous devez d'abord créer une catégorie",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            ItemForm addItemForm = new ItemForm(categories, selectedCategoryIndex);
            addItemForm.categories = categories;
            addItemForm.ShowDialog(parent);

            return addItemForm.DialogResult == DialogResult.OK
                    ? addItemForm.item : null;
        }

        public ItemForm(List<Category> categories, int selectedCategoryIndex, Item item = null) {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.plus.GetHicon());

            this.categories = categories;
            categories.ForEach(category => comboCategory.Items.Add(category.Name));

            if (selectedCategoryIndex < 0) selectedCategoryIndex = 0;
            comboCategory.SelectedIndex = selectedCategoryIndex;
            this.item.Category = categories[selectedCategoryIndex];

            if (item != null) FillFieldsFromItem(item);
        }

        private void FillFieldsFromItem(Item item) {
            this.item = item;
            textBoxName.Text = item.Name;
            textBoxShortcut.Text = item.Target;
            pictureBoxImgPreview.Image = item.Image;
            pictureBoxImgPreview.Tag = item.ImageId;
            comboCategory.SelectedIndex = categories.IndexOf(item.Category);
        }


        #region ****************** BUTTON LISTENERS ******************

        private void buttonBrowseShortcut_Click(object sender, EventArgs e) {
            textBoxShortcut.Text = selectExe();
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e) {
            var imgPath = selectPicture();
            if (!string.IsNullOrEmpty(imgPath)) {
                textBoxImagePath.Text = imgPath;
                pictureBoxImgPreview.Image = Image.FromFile(imgPath);
                pictureBoxImgPreview.Tag = Guid.NewGuid().ToString();
            }
        }

        private void buttonExtractImgFromShortcut_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxShortcut.Text))
                MessageBox.Show("Vous devez avoir sélectionné un programme au préalable.", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                pictureBoxImgPreview.Image = FileManager.ExtractIcon(textBoxShortcut.Text);
                pictureBoxImgPreview.Tag = Guid.NewGuid().ToString();
            }
        }

        private void buttonSelectResourceImage_Click(object sender, EventArgs e) {
            ResourcesForm resourcesForm = new ResourcesForm(true);
            resourcesForm.ShowDialog(this);

            if (resourcesForm.DialogResult == DialogResult.OK) {
                pictureBoxImgPreview.Image = resourcesForm.selectedImage;
                pictureBoxImgPreview.Tag = resourcesForm.selectedImageId;
            }
        }

        private void buttonValid_Click(object sender, EventArgs e) {
            if (!FieldsAreValid()) return;

            item.Name = textBoxName.Text;
            item.Target = textBoxShortcut.Text;

            if (pictureBoxImgPreview.Image != null && pictureBoxImgPreview.Tag != null) {
                image = pictureBoxImgPreview.Image;
                item.ImageId = pictureBoxImgPreview.Tag.ToString();
                FileManager.AddImageToResources(item.ImageId, image);
            }

            var newCategory = categories[comboCategory.SelectedIndex];
            if (!newCategory.Items.Contains(item)) {
                item.Category.Items.Remove(item);
                newCategory.Items.Add(item);
            }

            XmlManager.SaveCategories(categories);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        /***********************************************************************/

        #region ****************** MISC******************

        private bool FieldsAreValid() {
            var error = "";

            if (string.IsNullOrEmpty(textBoxName.Text))
                error = "Vous devez entrer un nom.";

            if (string.IsNullOrEmpty(textBoxShortcut.Text))
                error = "Un raccourci doit être sélectionné.";


            if (!string.IsNullOrEmpty(error)) {
                MessageBox.Show("Erreur: " + error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string selectExe() {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileDialog.Title = "Sélectionnez un executable";
            fileDialog.Filter = "Executables Windows (*.exe)|*.exe";
            fileDialog.RestoreDirectory = true;

            return (fileDialog.ShowDialog() == DialogResult.OK) ? fileDialog.FileName : null;
        }

        private string selectPicture() {
            var fileDialog = new OpenFileDialog();
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "Sélectionnez une image";
            fileDialog.Filter = "Images (*.jpg, *.jpeg, *.png, *.ico)|*.jpg;*.jpeg;*.png;*.ico";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            return fileDialog.ShowDialog() == DialogResult.OK ? fileDialog.FileName : null;
        }

        #endregion

    }
}

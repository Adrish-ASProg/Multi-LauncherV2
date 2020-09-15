using BrightIdeasSoftware;
using Multi_Launcher_V2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Multi_Launcher_V2.Model;
using Microsoft.VisualBasic;
using Multi_Launcher_V2.Utils;
using System.Linq;
using System.Collections.ObjectModel;

namespace Multi_Launcher_V2 {
    public partial class EditForm : Form {
        public List<Category> categories;

        FileManager fm = new FileManager();
        RearrangingDropSink listViewCategoriesDropSink;

        public bool needUpdate { get; set; }

        public EditForm(List<Category> categories) {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.edit.GetHicon());
            SetupListViews();

            needUpdate = false;

            this.categories = categories;
            UpdateCategoryList();
        }

        private void SetupListViews() {

            listViewCategoriesDropSink = new RearrangingDropSink {
                CanDropBetween = true,
                CanDropOnItem = true,
                CanDropOnSubItem = false,
                CanDropOnBackground = false,
                AcceptExternal = true,
                FeedbackColor = Color.Black
            };

            RearrangingDropSink listViewItemsDropSink = new RearrangingDropSink {
                CanDropBetween = true,
                CanDropOnItem = false,
                CanDropOnSubItem = false,
                CanDropOnBackground = false,
                AcceptExternal = false,
                FeedbackColor = Color.Black
            };

            listViewItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.Head‌​erSize);
            listViewCategories.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewCategories.DragSource = new SimpleDragSource();
            listViewItems.DragSource = new SimpleDragSource();
            listViewCategories.DropSink = listViewCategoriesDropSink;
            listViewItems.DropSink = listViewItemsDropSink;

            olvColumnItemName.ImageGetter = new ImageGetterDelegate(row => ((Item) row).ImageId);
        }





        #region ****************** CATEGORY ******************

        private void UpdateCategoryList() {
            listViewCategories.ClearObjects();
            listViewCategories.SetObjects(categories, false);
        }

        private void addCategory(object sender, EventArgs e) {
            var newCategory = new Category();
            newCategory.Name = PromptCategoryName("");

            if (string.IsNullOrEmpty(newCategory.Name)) return;

            categories.Add(newCategory);
            XmlManager.SaveCategories(categories);

            UpdateCategoryList();
            listViewCategories.SelectObject(newCategory);

            needUpdate = true;
        }

        private void renameCategory(object sender, EventArgs e) {
            var defaultName = listViewCategories.SelectedIndex > -1 ? listViewCategories.SelectedItems[0].Text : "";
            string newName = PromptCategoryName(defaultName);

            if (string.IsNullOrEmpty(newName)) return;

            var selectedCategory = listViewCategories.SelectedObject as Category;
            selectedCategory.Name = newName;
            XmlManager.SaveCategories(categories);

            UpdateCategoryList();
            listViewCategories.SelectObject(selectedCategory);

            needUpdate = true;
        }

        private void deleteCategory(object sender, EventArgs e) {
            var selectedCategory = listViewCategories.SelectedObject as Category;

            var result = MessageBox.Show("Voulez vous vraiment supprimer la catégorie \"" + selectedCategory.Name +
                "\" et tout les éléments qu'elle contient ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            categories.Remove(selectedCategory);

            XmlManager.SaveCategories(categories);

            UpdateCategoryList();
            listViewCategories.SelectedIndex = categories.Count > 0 ? 0 : -1;
            ShowItemList(listViewCategories.SelectedIndex);

            needUpdate = true;
        }

        private string PromptCategoryName(string defaultName) {
            var categoryName = Interaction.InputBox("Entrez un nom de catégorie", "Nom", defaultName, -1, -1);

            if (categoryName.Length > 20)
                MessageBox.Show("Le nom ne peut dépasser 20 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!string.IsNullOrEmpty(categoryName))
                return categoryName;

            return null;
        }

        #endregion




        #region ****************** ITEM ******************

        private void ShowItemList(Category category) {

            listViewItems.SmallImageList = category.ImageList;
            listViewItems.Columns[0].Text = category.Name;
            listViewItems.SetObjects(category.Items);
            listViewItems.AutoResizeColumns();
        }

        private void ShowItemList(int categoryId) {
            listViewItems.Items.Clear();

            // Sélection
            if (categoryId > -1) ShowItemList(categories[categoryId]);

            // Déselection
            else listViewItems.Columns[0].Text = "";

            listViewItems.AutoResizeColumns();
        }

        private void buttonAddItem_Click(object sender, EventArgs e) {

            var addedItem = ItemForm.ShowAddItemDialog(this, categories, listViewCategories.SelectedIndex);

            if (addedItem == null) return;

            ShowItemList(categories.IndexOf(addedItem.Category));
            listViewCategories.SelectObject(addedItem.Category);
            needUpdate = true;
        }

        private void contextMenuItemEdit_Click(object sender, EventArgs e) {
            var item = listViewItems.SelectedObject as Item;
            int oldCategoryIndex = categories.IndexOf(item.Category);

            ItemForm editItemForm = new ItemForm(categories, oldCategoryIndex, item);
            editItemForm.ShowDialog(this);

            if (editItemForm.DialogResult != DialogResult.OK) return;

            listViewCategories.SelectObject(item.Category);
            ShowItemList(categories.IndexOf(item.Category));

            XmlManager.SaveCategories(categories);

            needUpdate = true;
        }

        private void contextMenuItemDelete_Click(object sender, EventArgs e) {

            var item = listViewItems.SelectedObject as Item;

            DialogResult r = MessageBox.Show("Voulez vous vraiment supprimer " + item.Name + " ?",
                "Confirmation de suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (r != DialogResult.Yes) return;

            item.Category.Items.Remove(item);
            ShowItemList(listViewCategories.SelectedIndex);

            XmlManager.SaveCategories(categories);

            needUpdate = true;
        }

        #endregion




        #region ****************** LISTVIEW LISTENERS ******************

        private void listViewCategories_SelectedIndexChanged(object sender, EventArgs e) {
            ShowItemList(listViewCategories.SelectedIndex);
        }

        private void listViewCategories_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right
                && listViewCategories.FocusedItem.Bounds.Contains(e.Location)) {

                contextMenuListViewCategory.Show(Cursor.Position);
            }
        }

        private void listViewCategories_AfterSorting(object sender, AfterSortingEventArgs e) {
            if (e.ColumnToSort == null) return;

            categories.Sort((c1, c2) => e.SortOrder == SortOrder.Ascending
                ? c1.Name.CompareTo(c2.Name)
                : c2.Name.CompareTo(c1.Name));
            //categories = e.SortOrder == SortOrder.Ascending
            //    ? categories.OrderBy(c => c.Name).ToList()
            //    : categories.OrderByDescending(c => c.Name).ToList();

            needUpdate = true;
        }

        private void listViewCategories_Dropped(object sender, OlvDropEventArgs e) {
            if (e.DropTargetIndex == -1) return;

            var data = (OLVDataObject) e.DataObject;
            var draggedObject = data.ModelObjects[0];

            // Change category position
            if (draggedObject is Category) {
                // Set categories using listview order
                categories = listViewCategories.Objects.Cast<Category>().ToList();
                needUpdate = true;
            }

            // Change item's category
            else {
                var item = draggedObject as Item;
                var newCategory = e.DropTargetItem.RowObject as Category;

                if (item.Category == newCategory) return;

                item.Category.Items.Remove(item);
                newCategory.Items.Add(item);

                ShowItemList(categories.IndexOf(newCategory));
            }
        }

        private void listViewCategories_DragEnter(object sender, DragEventArgs e) {
            var data = (OLVDataObject) e.Data;
            var draggedObject = data.ModelObjects[0];
            listViewCategoriesDropSink.CanDropBetween = draggedObject is Category;
            listViewCategoriesDropSink.CanDropOnItem = draggedObject is Item;
            listViewCategories.DropSink = listViewCategoriesDropSink;
        }


        /* ----------------- Items ------------------- */


        private void listViewItem_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (listViewItems.FocusedItem.Bounds.Contains(e.Location)) {
                    contextMenuListViewItem.Show(Cursor.Position);
                }
            }
        }

        private void listViewItem_AfterSorting(object sender, AfterSortingEventArgs e) {
            if (e.ColumnToSort == null) return;

            var selectedCategory = ((Category) listViewCategories.SelectedObject);
            selectedCategory.SortItems(e.SortOrder);
            //selectedCategory.Items = new ObservableCollection<Item>(
            //    e.SortOrder == SortOrder.Ascending
            //    ? selectedCategory.Items.OrderBy(c => c.Name).ToList()
            //    : selectedCategory.Items.OrderByDescending(c => c.Name).ToList()
            //);

            needUpdate = true;
        }

        private void listViewItems_Dropped(object sender, OlvDropEventArgs e) {
            if (e.DropTargetIndex < 0) return;

            var data = e.DataObject as OLVDataObject;
            var draggedItem = data.ModelObjects[0] as Item;

            var oldCategoryIndex = draggedItem.Category.Items.IndexOf(draggedItem);
            draggedItem.Category.Items.Move(oldCategoryIndex, e.DropTargetIndex);

            needUpdate = true;
        }

        private void ReorderItems() {

        }

        #endregion





        #region ****************** BOUTONS ******************

        private void showHelp(object sender, EventArgs e) {
            string msg = "Un clic droit sur un élément vous permet de le modifier ou de le supprimer.\n\n" +
                "Vous pouvez déplacer les éléments en les faisant glisser, et les trier en cliquant sur le nom de la colonne.";

            MessageBox.Show(msg, "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quit(object sender, EventArgs e) {
            //if (needUpdate) xmlManager.UpdateCategories(categories);
            if (needUpdate) XmlManager.SaveCategories(categories);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

    }
}

namespace Multi_Launcher_V2
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.contextMenuListViewItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.listViewItems = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnItemName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.listViewCategories = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuListViewCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuCategoryRename = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCategoryDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListViewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewCategories)).BeginInit();
            this.contextMenuListViewCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(339, 235);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(281, 23);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Ajouter un programme";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(176, 275);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(131, 23);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Aide";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.showHelp);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(340, 275);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Retour";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.quit);
            // 
            // contextMenuListViewItem
            // 
            this.contextMenuListViewItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemEdit,
            this.contextMenuItemDelete});
            this.contextMenuListViewItem.Name = "contextMenuStrip1";
            this.contextMenuListViewItem.Size = new System.Drawing.Size(130, 48);
            // 
            // contextMenuItemEdit
            // 
            this.contextMenuItemEdit.Image = global::Multi_Launcher_V2.Properties.Resources.edit;
            this.contextMenuItemEdit.Name = "contextMenuItemEdit";
            this.contextMenuItemEdit.Size = new System.Drawing.Size(129, 22);
            this.contextMenuItemEdit.Text = "Modifier";
            this.contextMenuItemEdit.Click += new System.EventHandler(this.contextMenuItemEdit_Click);
            // 
            // contextMenuItemDelete
            // 
            this.contextMenuItemDelete.Image = global::Multi_Launcher_V2.Properties.Resources.delete;
            this.contextMenuItemDelete.Name = "contextMenuItemDelete";
            this.contextMenuItemDelete.Size = new System.Drawing.Size(129, 22);
            this.contextMenuItemDelete.Text = "Supprimer";
            this.contextMenuItemDelete.Click += new System.EventHandler(this.contextMenuItemDelete_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(27, 235);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(281, 23);
            this.buttonAddCategory.TabIndex = 10;
            this.buttonAddCategory.Text = "Ajouter une catégorie";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.addCategory);
            // 
            // listViewItems
            // 
            this.listViewItems.AllColumns.Add(this.olvColumnItemName);
            this.listViewItems.CellEditUseWholeCell = false;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnItemName});
            this.listViewItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(340, 24);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.ShowGroups = false;
            this.listViewItems.Size = new System.Drawing.Size(279, 200);
            this.listViewItems.TabIndex = 12;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.AfterSorting += new System.EventHandler<BrightIdeasSoftware.AfterSortingEventArgs>(this.listViewItem_AfterSorting);
            this.listViewItems.Dropped += new System.EventHandler<BrightIdeasSoftware.OlvDropEventArgs>(this.listViewItems_Dropped);
            this.listViewItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewItem_MouseClick);
            // 
            // olvColumnItemName
            // 
            this.olvColumnItemName.AspectName = "Name";
            this.olvColumnItemName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnItemName.Text = "";
            this.olvColumnItemName.Width = 274;
            // 
            // listViewCategories
            // 
            this.listViewCategories.AllColumns.Add(this.olvColumnName);
            this.listViewCategories.CellEditUseWholeCell = false;
            this.listViewCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName});
            this.listViewCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewCategories.HideSelection = false;
            this.listViewCategories.Location = new System.Drawing.Point(28, 24);
            this.listViewCategories.MultiSelect = false;
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.ShowGroups = false;
            this.listViewCategories.Size = new System.Drawing.Size(279, 200);
            this.listViewCategories.TabIndex = 11;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            this.listViewCategories.View = System.Windows.Forms.View.Details;
            this.listViewCategories.AfterSorting += new System.EventHandler<BrightIdeasSoftware.AfterSortingEventArgs>(this.listViewCategories_AfterSorting);
            this.listViewCategories.Dropped += new System.EventHandler<BrightIdeasSoftware.OlvDropEventArgs>(this.listViewCategories_Dropped);
            this.listViewCategories.SelectedIndexChanged += new System.EventHandler(this.listViewCategories_SelectedIndexChanged);
            this.listViewCategories.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewCategories_DragEnter);
            this.listViewCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCategories_MouseClick);
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnName.Text = "Catégories";
            this.olvColumnName.Width = 275;
            // 
            // contextMenuListViewCategory
            // 
            this.contextMenuListViewCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCategoryRename,
            this.contextMenuCategoryDelete});
            this.contextMenuListViewCategory.Name = "contextMenuStrip1";
            this.contextMenuListViewCategory.Size = new System.Drawing.Size(134, 48);
            // 
            // contextMenuCategoryRename
            // 
            this.contextMenuCategoryRename.Image = global::Multi_Launcher_V2.Properties.Resources.edit;
            this.contextMenuCategoryRename.Name = "contextMenuCategoryRename";
            this.contextMenuCategoryRename.Size = new System.Drawing.Size(133, 22);
            this.contextMenuCategoryRename.Text = "Renommer";
            this.contextMenuCategoryRename.Click += new System.EventHandler(this.renameCategory);
            // 
            // contextMenuCategoryDelete
            // 
            this.contextMenuCategoryDelete.Image = global::Multi_Launcher_V2.Properties.Resources.delete;
            this.contextMenuCategoryDelete.Name = "contextMenuCategoryDelete";
            this.contextMenuCategoryDelete.Size = new System.Drawing.Size(133, 22);
            this.contextMenuCategoryDelete.Text = "Supprimer";
            this.contextMenuCategoryDelete.Click += new System.EventHandler(this.deleteCategory);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 311);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.listViewCategories);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifier les programmes";
            this.contextMenuListViewItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewCategories)).EndInit();
            this.contextMenuListViewCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuListViewItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDelete;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuListViewCategory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCategoryRename;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCategoryDelete;
        private BrightIdeasSoftware.ObjectListView listViewCategories;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.ObjectListView listViewItems;
        private BrightIdeasSoftware.OLVColumn olvColumnItemName;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemEdit;
    }
}
namespace Multi_Launcher_V2
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemResources = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangelog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemGenerateDefaultSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuItemRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInfo = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.objectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnImage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTarget = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menu.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFichier,
            this.menuItemTools,
            this.menuItemHelp,
            this.debugToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(759, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemFichier
            // 
            this.menuItemFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemEdit,
            this.menuItemSettings,
            this.menuItemQuit});
            this.menuItemFichier.Name = "menuItemFichier";
            this.menuItemFichier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuItemFichier.Size = new System.Drawing.Size(54, 20);
            this.menuItemFichier.Text = "&Fichier";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Image = global::Multi_Launcher_V2.Properties.Resources.plus;
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(202, 22);
            this.menuItemAdd.Text = "Ajouter un programme";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Image = global::Multi_Launcher_V2.Properties.Resources.edit;
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(202, 22);
            this.menuItemEdit.Tag = "Vous permet de modifier les catégories et les programmes: Noms, images, ordre..";
            this.menuItemEdit.Text = "&Modifier les programme";
            this.menuItemEdit.Click += new System.EventHandler(this.menuItemEdit_Click);
            this.menuItemEdit.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.menuItemEdit.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Image = global::Multi_Launcher_V2.Properties.Resources.settings;
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(202, 22);
            this.menuItemSettings.Tag = "Permet de définir vos préférences";
            this.menuItemSettings.Text = "&Paramètres";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            this.menuItemSettings.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.menuItemSettings.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Image = global::Multi_Launcher_V2.Properties.Resources.exit;
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.Size = new System.Drawing.Size(202, 22);
            this.menuItemQuit.Tag = "Quitte l\'application sans la faire tourner en arrière-plan.";
            this.menuItemQuit.Text = "&Quitter";
            this.menuItemQuit.Click += new System.EventHandler(this.quit);
            this.menuItemQuit.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.menuItemQuit.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemResources,
            this.menuItemExtract});
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(50, 20);
            this.menuItemTools.Text = "Outils";
            // 
            // menuItemResources
            // 
            this.menuItemResources.Image = global::Multi_Launcher_V2.Properties.Resources.image;
            this.menuItemResources.Name = "menuItemResources";
            this.menuItemResources.Size = new System.Drawing.Size(201, 22);
            this.menuItemResources.Tag = "Affiche une fenetre contenant toutes les images enregistrées que vous pouvez util" +
    "iser.";
            this.menuItemResources.Text = "Images enregistrées";
            this.menuItemResources.Click += new System.EventHandler(this.menuItemResources_Click);
            this.menuItemResources.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.menuItemResources.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // menuItemExtract
            // 
            this.menuItemExtract.Image = global::Multi_Launcher_V2.Properties.Resources.wrench;
            this.menuItemExtract.Name = "menuItemExtract";
            this.menuItemExtract.Size = new System.Drawing.Size(201, 22);
            this.menuItemExtract.Text = "Extracteur de ressources";
            this.menuItemExtract.Click += new System.EventHandler(this.menuItemExtract_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUpdate,
            this.menuItemChangelog,
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(43, 20);
            this.menuItemHelp.Text = "&Aide";
            // 
            // menuItemUpdate
            // 
            this.menuItemUpdate.Image = global::Multi_Launcher_V2.Properties.Resources.update;
            this.menuItemUpdate.Name = "menuItemUpdate";
            this.menuItemUpdate.Size = new System.Drawing.Size(193, 22);
            this.menuItemUpdate.Text = "Vérifier les mises à jour";
            this.menuItemUpdate.Click += new System.EventHandler(this.menuItemUpdate_Click);
            // 
            // menuItemChangelog
            // 
            this.menuItemChangelog.Image = global::Multi_Launcher_V2.Properties.Resources.changelog;
            this.menuItemChangelog.Name = "menuItemChangelog";
            this.menuItemChangelog.Size = new System.Drawing.Size(193, 22);
            this.menuItemChangelog.Text = "Notes de mise à jour";
            this.menuItemChangelog.Click += new System.EventHandler(this.menuItemChangelog_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Image = global::Multi_Launcher_V2.Properties.Resources.info;
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(193, 22);
            this.menuItemAbout.Text = "À propos";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemGenerateDefaultSettings,
            this.testToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // toolStripItemGenerateDefaultSettings
            // 
            this.toolStripItemGenerateDefaultSettings.Name = "toolStripItemGenerateDefaultSettings";
            this.toolStripItemGenerateDefaultSettings.Size = new System.Drawing.Size(205, 22);
            this.toolStripItemGenerateDefaultSettings.Text = "Generate default settings";
            this.toolStripItemGenerateDefaultSettings.Click += new System.EventHandler(this.toolStripItemGenerateDefaultSettings_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Multi-Launcher V2";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.ShowForm);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuItemRestore,
            this.trayMenuItemQuit});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(124, 48);
            // 
            // trayMenuItemRestore
            // 
            this.trayMenuItemRestore.Name = "trayMenuItemRestore";
            this.trayMenuItemRestore.Size = new System.Drawing.Size(123, 22);
            this.trayMenuItemRestore.Text = "Restaurer";
            this.trayMenuItemRestore.Click += new System.EventHandler(this.ShowForm);
            // 
            // trayMenuItemQuit
            // 
            this.trayMenuItemQuit.Name = "trayMenuItemQuit";
            this.trayMenuItemQuit.Size = new System.Drawing.Size(123, 22);
            this.trayMenuItemQuit.Text = "Quitter";
            this.trayMenuItemQuit.Click += new System.EventHandler(this.quit);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(12, 362);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(735, 22);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(671, 5);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Maximum = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar.Size = new System.Drawing.Size(72, 16);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // tabContainer
            // 
            this.tabContainer.Location = new System.Drawing.Point(12, 27);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(735, 330);
            this.tabContainer.TabIndex = 8;
            this.tabContainer.Visible = false;
            // 
            // objectListView
            // 
            this.objectListView.AllColumns.Add(this.olvColumnName);
            this.objectListView.AllColumns.Add(this.olvColumnImage);
            this.objectListView.AllColumns.Add(this.olvColumnCategory);
            this.objectListView.AllColumns.Add(this.olvColumnTarget);
            this.objectListView.AllowColumnReorder = true;
            this.objectListView.CellEditUseWholeCell = false;
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnImage,
            this.olvColumnCategory,
            this.olvColumnTarget});
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.FullRowSelect = true;
            this.objectListView.HideSelection = false;
            this.objectListView.Location = new System.Drawing.Point(12, 27);
            this.objectListView.Name = "objectListView";
            this.objectListView.RowHeight = 25;
            this.objectListView.ShowGroups = false;
            this.objectListView.Size = new System.Drawing.Size(735, 330);
            this.objectListView.TabIndex = 9;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.Details;
            this.objectListView.Visible = false;
            // 
            // olvColumnImage
            // 
            this.olvColumnImage.DisplayIndex = 0;
            this.olvColumnImage.ImageAspectName = "Image";
            this.olvColumnImage.Text = "Image";
            this.olvColumnImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Text = "Nom";
            this.olvColumnName.Width = 90;
            // 
            // olvColumnCategory
            // 
            this.olvColumnCategory.AspectName = "Category.Name";
            this.olvColumnCategory.MinimumWidth = 80;
            this.olvColumnCategory.Text = "Catégorie";
            this.olvColumnCategory.Width = 90;
            // 
            // olvColumnTarget
            // 
            this.olvColumnTarget.AspectName = "Target";
            this.olvColumnTarget.FillsFreeSpace = true;
            this.olvColumnTarget.Text = "Cible";
            this.olvColumnTarget.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 391);
            this.Controls.Add(this.objectListView);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Launcher V2";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.trayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFichier;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemRestore;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ToolStripMenuItem menuItemResources;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemExtract;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemChangelog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemGenerateDefaultSettings;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.TabControl tabContainer;
        private BrightIdeasSoftware.ObjectListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnCategory;
        private BrightIdeasSoftware.OLVColumn olvColumnTarget;
        private BrightIdeasSoftware.OLVColumn olvColumnImage;
    }
}


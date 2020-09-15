//using AutoUpdaterDotNET;
using Multi_Launcher_V2.Model;
using Multi_Launcher_V2.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Multi_Launcher_V2 {
    public partial class MainForm : Form {

        private bool allowVisible = false;
        private bool initializationNeeded = true;
        private ImageList ImageList = new ImageList();

        private List<Category> categories = new List<Category>();
        private Settings settings;

        private void test() { }

        public MainForm() {
            InitializeComponent();

            // checkForUpdate(true);


            // Hotkey linked to handle, not working if handle change
            HandleCreated += new EventHandler((sender, e) => {

                if (initializationNeeded) {
                    initializationNeeded = false;
                    InitializeSettingsAndUI();
                }

                if (settings == null) return;
                HotKeyManager.InitializeHotKey(Handle, settings.shortcutModifier, settings.shortcutKey);
            });

            HandleDestroyed += new EventHandler((sender, e) => {
                HotKeyManager.UnregisterHotKey(Handle);
            });
        }


        #region ****************** UI ******************

        protected override void SetVisibleCore(bool value) {
            if (!allowVisible) {
                value = false;
                if (!IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        private void InitializeSettingsAndUI() {
            StartLoading();

            var imgSize = objectListView.RowHeight - 5;
            ImageList.ImageSize = new Size(imgSize, imgSize);
            objectListView.SmallImageList = ImageList;
            olvColumnImage.ImageGetter = row => ((Item) row).ImageId;
            objectListView.ItemActivate += (s, e) => {
                var item = (Item) objectListView.GetModelObject(objectListView.SelectedIndex);
                RunProgram(item);
            };


            var backgroundThread = new Thread(() => {

                // Get settings + Set hotkey
                settings = XmlManager.GetSettings();
                MethodInvoker settingsDelegate = () => {
                    HotKeyManager.InitializeHotKey(Handle, settings.shortcutModifier, settings.shortcutKey);
                    if (!settings.stayMinimized) ShowForm(null, null);
                };
                Invoke(settingsDelegate);



                // Get categories + Set image list
                categories = XmlManager.GetCategories();

                MethodInvoker categoriesDelegate = () => BuildImageList();
                Invoke(categoriesDelegate);


                BuildUI();
            });

            backgroundThread.Start();
        }

        private void SetupUIAsync() {
            StartLoading();
            new Thread(BuildUI).Start();
        }

        private void BuildUI() {
            if (settings.detailsView) BuildListViewUI();
            else BuildTabPageUI();
        }

        private void BuildTabPageUI() {
            var tabPages = categories.Select(buildTabPageFromCategory).ToArray();

            MethodInvoker addTabPageDelegate = () => {
                tabContainer.TabPages.AddRange(tabPages);
                StopLoading();
            };

            // Current thread is not UI thread
            Invoke(addTabPageDelegate);
        }

        private void BuildListViewUI() {

            var listViewItems = categories
                .SelectMany(category => category.Items)
                .ToArray();

            MethodInvoker addListViewDelegate = () => {
                objectListView.SetObjects(listViewItems, false);
                StopLoading();
            };

            // Current thread is not UI thread
            Invoke(addListViewDelegate);
        }

        private TabPage buildTabPageFromCategory(Category category) {

            var flowLayout = new FlowLayoutPanel { Dock = DockStyle.Fill };
            foreach (Item item in category.Items) {
                var itemComponent = new ItemComponent(item, settings);
                itemComponent.setOnPictureClicked(RunProgram);
                itemComponent.setOnMouseEnter(new EventHandler(ShowHelpOnHover));
                itemComponent.setOnMouseLeave(new EventHandler(EraseHelp));
                flowLayout.Controls.Add(itemComponent);
            }

            var tabPage = new TabPage { Text = category.Name, BackColor = Color.White };
            tabPage.Controls.Add(flowLayout);

            return tabPage;
        }

        private void StartLoading() {
            progressBar.Visible = true;
            tabContainer.Visible = false;
            objectListView.Visible = false;

            menuItemAdd.Enabled = false;
            menuItemEdit.Enabled = false;
            menuItemSettings.Enabled = false;
            tabContainer.Controls.Clear();
        }

        private void StopLoading() {
            tabContainer.Visible = !settings.detailsView;
            objectListView.Visible = settings.detailsView;

            menuItemAdd.Enabled = true;
            menuItemEdit.Enabled = true;
            menuItemSettings.Enabled = true;
            progressBar.Visible = false;
        }

        private void BuildImageList() {
            ImageList.Images.Clear();
            categories.SelectMany(category => category.Items)
                .ToList()
                .ForEach(item => {
                    if (item.ImageId != null)
                        ImageList.Images.Add(item.ImageId, item.Image);
                });
        }

        public void ShowForm(object sender, EventArgs e) {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            allowVisible = true;

            Show();
            BringToFront();
            Activate();
        }

        #endregion


        #region ****************** MENU ******************

        private void menuItemAdd_Click(object sender, EventArgs e) {
            Item item = ItemForm.ShowAddItemDialog(this, categories, 0);
            if (item != null) {
                if (item.Image != null && item.ImageId != null
                    && !ImageList.Images.ContainsKey(item.ImageId))
                    ImageList.Images.Add(item.ImageId, item.Image);
                SetupUIAsync();
            }
        }

        private void menuItemEdit_Click(object sender, EventArgs e) {
            EditForm editForm = new EditForm(categories);
            editForm.ShowDialog(this);
            categories = editForm.categories;

            if (editForm.needUpdate) {
                BuildImageList();
                SetupUIAsync();
            }
        }

        private void menuItemSettings_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm(settings);
            settingsForm.ShowDialog(this);
            settings = settingsForm.settings;

            if (settingsForm.shouldReloadUI) SetupUIAsync();
        }


        private void menuItemResources_Click(object sender, EventArgs e) {
            var resourcesForm = new ResourcesForm(false);
            resourcesForm.ShowDialog(this);
            if (resourcesForm.shouldRefreshUI) SetupUIAsync();
        }

        private void menuItemExtract_Click(object sender, EventArgs e) {
            try {
                CmdManager.ExecuteCommand("tls\\ResourcesExtract\\ResourcesExtract.exe");
            }
            catch (Exception ex) {
                MessageBox.Show($"Impossible de démarrer le programme: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void menuItemUpdate_Click(object sender, EventArgs e) {
            UpdateManager.CheckForUpdate(false);
        }

        private void menuItemChangelog_Click(object sender, EventArgs e) {
            var message = "Vous pouvez consulter les dernières mises à jour directement sur GitHub en cliquant sur le bouton 'Aide'";
            var changelogUrl = "https://github.com/Adrish-ASProg/Multi-LauncherV2/blob/master/CHANGELOG.md";

            MessageBox.Show(message, $"Notes de Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, 0, changelogUrl);
        }

        private void menuItemAbout_Click(object sender, EventArgs e) {

            var appVersion = typeof(MainForm).Assembly.GetName().Version;
            var title = "À Propos";
            var message = $"Multi-Launcher V2 - v{appVersion} \n© 2020 ASProg - All Rights Reserved";

            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            test();
        }

        private void toolStripItemGenerateDefaultSettings_Click(object sender, EventArgs e) {

            var result = MessageBox.Show("Voulez vous vraiment générer un nouveau fichier de configuration ? \n" +
                "Cela écrasera tous vos paramètres, les catégories ainsi que les items existants",
                "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            XmlManager.ResetSettings();
            SetupUIAsync();
        }

        #endregion

        #region ****************** MISC ******************

        // Catch when a HotKey is pressed
        protected override void WndProc(ref Message m) {
            bool hasOpenModal = Visible && !CanFocus;

            if (m.Msg == 0x0312 && !hasOpenModal) {
                if (Visible) Hide();
                else ShowForm(null, null);
            }

            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);

            if (e.CloseReason != CloseReason.UserClosing) return;

            var quitMessage = "Laisser tourner l'application en arrière-plan ?\n\n" +
                "Vous pourrez ainsi réafficher la fenêtre grâce à votre raccourci clavier " +
                "ou à l'aide de l'icône dans la barre des tâches.\n\n" +
                "Cliquez sur Non pour réellement fermer l'application.";

            switch (MessageBox.Show(this, quitMessage, "Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    e.Cancel = true;
                    Hide();
                    break;

                case DialogResult.No:
                    quit(null, null);
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

                default:
                    break;
            }
        }

        private void RunProgram(Item i) {
            try {
                CmdManager.ExecuteCommand(i.Target);
                if (settings.hideAfterLaunch) Hide();
            }
            catch (Exception e) {
                MessageBox.Show($"Impossible de démarrer le programme: {e.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowHelpOnHover(object sender, EventArgs e) {
            string info = "";
            if (sender.GetType() != menuItemEdit.GetType()) {
                Control c = ((Control) sender);
                if (c.Tag != null)
                    info = c.Tag.ToString();
            }
            else {
                ToolStripMenuItem t = ((ToolStripMenuItem) sender);
                if (t.Tag != null)
                    info = t.Tag.ToString();
            }

            labelInfo.Text = info;
        }

        private void EraseHelp(object sender, EventArgs e) {
            labelInfo.Text = "";
        }

        private void quit(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion
    }
}
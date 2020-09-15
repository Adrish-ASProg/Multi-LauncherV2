using System;
using System.IO;
using System.Windows.Forms;
using Multi_Launcher_V2.Properties;
using System.Drawing;
using Settings = Multi_Launcher_V2.Model.Settings;
using Multi_Launcher_V2.Utils;

namespace Multi_Launcher_V2 {
    public partial class SettingsForm : Form {

        public Settings settings;
        public bool shouldReloadUI = false;

        public SettingsForm(Settings settings) {
            InitializeComponent();

            Icon = Icon.FromHandle(Resources.settings.GetHicon());

            this.settings = settings;
            setupUiFromSettings();
        }

        void setupUiFromSettings() {
            if (settings.shortcutModifier != Keys.None) {
                checkBoxShortcut.Checked = true;
                comboBoxShortcut1.SelectedItem = settings.shortcutModifier.ToString();
                comboBoxShortcut2.SelectedItem = settings.shortcutKey.ToString();
            } else {
                checkBoxShortcut.Checked = false;
                comboBoxShortcut1.SelectedItem = comboBoxShortcut1.Items[0];
                comboBoxShortcut2.SelectedItem = comboBoxShortcut2.Items[0];
            }

            checkBoxStartup.Checked = settings.Startup;
            checkBoxStayMinimized.Checked = settings.stayMinimized;
            checkBoxHideAfterLaunch.Checked = settings.hideAfterLaunch;

            numericUpDownImgSize.Value = settings.imgSize;
            checkBoxImgNames.Checked = settings.names;

            radioDoubleClic.Checked = settings.doubleClick;
            radioButtonViewDetails.Checked = settings.detailsView;

            groupBoxLaunch.Enabled = !settings.detailsView;
            groupBoxImages.Enabled = !settings.detailsView;

            buttonApply.Enabled = false;
            shouldReloadUI = false;
        }

        void onChange(object sender, EventArgs e) {
            buttonApply.Enabled = true;
        }


        /****************************** BOUTONS ******************************/

        void buttonApply_Click(object sender, EventArgs e) {
            applyChanges();
        }

        private void onViewModeChanged(object sender, EventArgs e) {
            groupBoxLaunch.Enabled = radioButtonViewGrid.Checked;
            groupBoxImages.Enabled = radioButtonViewGrid.Checked;

            onUISettingsChange(sender, e);
        }

        private void onUISettingsChange(object sender, EventArgs e) {
            shouldReloadUI = true;
            onChange(sender, e);
        }

        void saveChanges(object sender, EventArgs e) {
            if (applyChanges())
                quit(sender, e);
        }

        bool applyChanges() {
            if (checkBoxShortcut.Checked) {
                settings.shortcutModifier = (Keys) Enum.Parse(typeof(Keys), comboBoxShortcut1.SelectedItem.ToString(), true);
                settings.shortcutKey = (Keys) Enum.Parse(typeof(Keys), comboBoxShortcut2.SelectedItem.ToString(), true);
                if (settings.shortcutModifier == Keys.Alt && settings.shortcutKey == Keys.F4) {
                    MessageBox.Show("Impossible de sélectionner ce raccourci, vos modifications n'ont pas été sauvegardées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else {
                settings.shortcutModifier = Keys.None;
                settings.shortcutKey = Keys.None;
            }
            settings.imgSize = decimal.ToInt16(numericUpDownImgSize.Value);
            settings.names = checkBoxImgNames.Checked;
            settings.Startup = checkBoxStartup.Checked;
            settings.stayMinimized = checkBoxStayMinimized.Checked;
            settings.hideAfterLaunch = checkBoxHideAfterLaunch.Checked;
            settings.doubleClick = radioDoubleClic.Checked;
            settings.detailsView = radioButtonViewDetails.Checked;

            setStartup(checkBoxStartup.Checked);
            XmlManager.SaveSettings(settings);
            HotKeyManager.InitializeHotKey(Owner.Handle, settings.shortcutModifier, settings.shortcutKey);

            buttonApply.Enabled = false;

            return true;
        }

        void setStartup(bool startAtBoot) {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\MultiLauncherV2.lnk";

            if (startAtBoot) FileManager.CreateApplicationShortcut(startupPath);
            else if (File.Exists(startupPath)) File.Delete(startupPath);
        }

        void quit(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void helpRequested(object sender, HelpEventArgs hlpevent) {
            Control senderControl = (Control) sender;
            if (senderControl.Tag != null) MessageBox.Show(senderControl.Tag.ToString().Replace("|", "\n"), "Aide");
            hlpevent.Handled = true;
        }

        private void checkBoxShortcut_CheckStateChanged(object sender, EventArgs e) {
            onChange(sender, e);
            comboBoxShortcut1.Enabled = checkBoxShortcut.Checked;
            comboBoxShortcut2.Enabled = checkBoxShortcut.Checked;
        }

        private void ShowHelpOnHover(object sender, EventArgs e) {
            Control control = (Control) sender;
            if (control.Tag != null)
                labelInfo.Text = control.Tag.ToString().Replace("<br>", Environment.NewLine);
        }

        private void EraseHelp(object sender, EventArgs e) {
            labelInfo.Text = "";
        }


        /*
        public bool IsAdmin()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                isAdmin = false;
            }

            return isAdmin;
        }

        private void checkAdmin(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show("Vous devez éxecuter le programme en tant qu'administrateur pour modifier ce paramètre.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxStartup.Checked = !checkBoxStartup.Checked;
            }
            else
                buttonApply.Enabled = true;
        }
        */
    }
}

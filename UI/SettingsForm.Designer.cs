namespace Multi_Launcher_V2
{
    partial class SettingsForm
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
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxStartup = new System.Windows.Forms.CheckBox();
            this.numericUpDownImgSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxShortcut1 = new System.Windows.Forms.ComboBox();
            this.labelImgSize = new System.Windows.Forms.Label();
            this.comboBoxShortcut2 = new System.Windows.Forms.ComboBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.checkBoxShortcut = new System.Windows.Forms.CheckBox();
            this.checkBoxHideAfterLaunch = new System.Windows.Forms.CheckBox();
            this.checkBoxStayMinimized = new System.Windows.Forms.CheckBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.radioButtonViewDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonViewGrid = new System.Windows.Forms.RadioButton();
            this.groupBoxLaunch = new System.Windows.Forms.GroupBox();
            this.radioDoubleClic = new System.Windows.Forms.RadioButton();
            this.radioSimpleClic = new System.Windows.Forms.RadioButton();
            this.checkBoxImgNames = new System.Windows.Forms.CheckBox();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImgSize)).BeginInit();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.groupBoxLaunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(15, 220);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 6;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.saveChanges);
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(198, 220);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Appliquer";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(381, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.quit);
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartup.Location = new System.Drawing.Point(6, 108);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(189, 17);
            this.checkBoxStartup.TabIndex = 3;
            this.checkBoxStartup.Tag = "L\'application se lancera dès le démarrage de Windows.<br>Requiert les privilèges " +
    "administrateur.";
            this.checkBoxStartup.Text = "Lancer au démarrage de Windows";
            this.checkBoxStartup.UseVisualStyleBackColor = true;
            this.checkBoxStartup.CheckedChanged += new System.EventHandler(this.onChange);
            this.checkBoxStartup.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.checkBoxStartup.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.checkBoxStartup.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // numericUpDownImgSize
            // 
            this.numericUpDownImgSize.Location = new System.Drawing.Point(125, 20);
            this.numericUpDownImgSize.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownImgSize.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownImgSize.Name = "numericUpDownImgSize";
            this.numericUpDownImgSize.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownImgSize.TabIndex = 4;
            this.numericUpDownImgSize.Tag = "Vous permet de changer la taille des images (de 70 à 120em)";
            this.numericUpDownImgSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownImgSize.ValueChanged += new System.EventHandler(this.onUISettingsChange);
            this.numericUpDownImgSize.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            // 
            // comboBoxShortcut1
            // 
            this.comboBoxShortcut1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShortcut1.Enabled = false;
            this.comboBoxShortcut1.FormattingEnabled = true;
            this.comboBoxShortcut1.Items.AddRange(new object[] {
            "Control",
            "Alt",
            "Shift"});
            this.comboBoxShortcut1.Location = new System.Drawing.Point(4, 43);
            this.comboBoxShortcut1.Name = "comboBoxShortcut1";
            this.comboBoxShortcut1.Size = new System.Drawing.Size(85, 21);
            this.comboBoxShortcut1.TabIndex = 1;
            this.comboBoxShortcut1.Tag = "Vous pouvez choisir une combinaison de touche ici pour afficher/cacher la fenêtre" +
    " principale rapidement.";
            this.comboBoxShortcut1.SelectedIndexChanged += new System.EventHandler(this.onChange);
            this.comboBoxShortcut1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.comboBoxShortcut1.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.comboBoxShortcut1.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // labelImgSize
            // 
            this.labelImgSize.Location = new System.Drawing.Point(18, 20);
            this.labelImgSize.Name = "labelImgSize";
            this.labelImgSize.Size = new System.Drawing.Size(101, 20);
            this.labelImgSize.TabIndex = 10;
            this.labelImgSize.Tag = "Vous permet de changer la taille des images (de 70 à 120em)";
            this.labelImgSize.Text = "Taille des images";
            this.labelImgSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelImgSize.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.labelImgSize.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.labelImgSize.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // comboBoxShortcut2
            // 
            this.comboBoxShortcut2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShortcut2.Enabled = false;
            this.comboBoxShortcut2.FormattingEnabled = true;
            this.comboBoxShortcut2.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxShortcut2.Location = new System.Drawing.Point(110, 43);
            this.comboBoxShortcut2.Name = "comboBoxShortcut2";
            this.comboBoxShortcut2.Size = new System.Drawing.Size(85, 21);
            this.comboBoxShortcut2.TabIndex = 2;
            this.comboBoxShortcut2.Tag = "Vous pouvez choisir une combinaison de touche ici pour afficher/cacher la fenêtre" +
    " principale rapidement.";
            this.comboBoxShortcut2.SelectedIndexChanged += new System.EventHandler(this.onChange);
            this.comboBoxShortcut2.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.comboBoxShortcut2.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.comboBoxShortcut2.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.checkBoxShortcut);
            this.groupBoxGeneral.Controls.Add(this.checkBoxHideAfterLaunch);
            this.groupBoxGeneral.Controls.Add(this.checkBoxStayMinimized);
            this.groupBoxGeneral.Controls.Add(this.labelPlus);
            this.groupBoxGeneral.Controls.Add(this.comboBoxShortcut2);
            this.groupBoxGeneral.Controls.Add(this.comboBoxShortcut1);
            this.groupBoxGeneral.Controls.Add(this.checkBoxStartup);
            this.groupBoxGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxGeneral.Location = new System.Drawing.Point(15, 15);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(200, 160);
            this.groupBoxGeneral.TabIndex = 13;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Général";
            // 
            // checkBoxShortcut
            // 
            this.checkBoxShortcut.AutoSize = true;
            this.checkBoxShortcut.Location = new System.Drawing.Point(37, 21);
            this.checkBoxShortcut.Name = "checkBoxShortcut";
            this.checkBoxShortcut.Size = new System.Drawing.Size(115, 17);
            this.checkBoxShortcut.TabIndex = 15;
            this.checkBoxShortcut.Tag = "Vous pouvez choisir une combinaison de touche ici pour afficher/cacher la fenêtre" +
    " principale rapidement.";
            this.checkBoxShortcut.Text = "Raccourci clavier :";
            this.checkBoxShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxShortcut.UseVisualStyleBackColor = true;
            this.checkBoxShortcut.CheckStateChanged += new System.EventHandler(this.checkBoxShortcut_CheckStateChanged);
            this.checkBoxShortcut.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.checkBoxShortcut.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // checkBoxHideAfterLaunch
            // 
            this.checkBoxHideAfterLaunch.AutoSize = true;
            this.checkBoxHideAfterLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHideAfterLaunch.Location = new System.Drawing.Point(5, 79);
            this.checkBoxHideAfterLaunch.Name = "checkBoxHideAfterLaunch";
            this.checkBoxHideAfterLaunch.Size = new System.Drawing.Size(191, 17);
            this.checkBoxHideAfterLaunch.TabIndex = 14;
            this.checkBoxHideAfterLaunch.Tag = "L\'application se cachera automatiquement après avoir lancé un de vos programme.";
            this.checkBoxHideAfterLaunch.Text = "Cacher après lancement d\'un prog.";
            this.checkBoxHideAfterLaunch.UseVisualStyleBackColor = true;
            this.checkBoxHideAfterLaunch.CheckedChanged += new System.EventHandler(this.onChange);
            this.checkBoxHideAfterLaunch.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.checkBoxHideAfterLaunch.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // checkBoxStayMinimized
            // 
            this.checkBoxStayMinimized.AutoSize = true;
            this.checkBoxStayMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStayMinimized.Location = new System.Drawing.Point(20, 136);
            this.checkBoxStayMinimized.Name = "checkBoxStayMinimized";
            this.checkBoxStayMinimized.Size = new System.Drawing.Size(158, 17);
            this.checkBoxStayMinimized.TabIndex = 13;
            this.checkBoxStayMinimized.Tag = "L\'application se lancera en arrière-plan, la fenêtre restera invisible (le raccou" +
    "rci clavier et l\'icône dans la barre des tâches seront disponibles).";
            this.checkBoxStayMinimized.Text = "Rester caché au démarrage";
            this.checkBoxStayMinimized.UseVisualStyleBackColor = true;
            this.checkBoxStayMinimized.CheckedChanged += new System.EventHandler(this.onChange);
            this.checkBoxStayMinimized.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.checkBoxStayMinimized.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.checkBoxStayMinimized.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(93, 47);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(13, 13);
            this.labelPlus.TabIndex = 12;
            this.labelPlus.Tag = "Vous pouvez choisir une combinaison de touche ici pour afficher/cacher la fenêtre" +
    " principale rapidement.";
            this.labelPlus.Text = "+";
            this.labelPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlus.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.labelPlus.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.labelPlus.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.groupBoxView);
            this.groupBoxItems.Controls.Add(this.groupBoxLaunch);
            this.groupBoxItems.Controls.Add(this.checkBoxImgNames);
            this.groupBoxItems.Controls.Add(this.labelImgSize);
            this.groupBoxItems.Controls.Add(this.numericUpDownImgSize);
            this.groupBoxItems.Location = new System.Drawing.Point(255, 15);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(200, 160);
            this.groupBoxItems.TabIndex = 14;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Programmes";
            // 
            // groupBoxView
            // 
            this.groupBoxView.Controls.Add(this.radioButtonViewDetails);
            this.groupBoxView.Controls.Add(this.radioButtonViewGrid);
            this.groupBoxView.Location = new System.Drawing.Point(6, 112);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(188, 42);
            this.groupBoxView.TabIndex = 15;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Tag = "Choisissez si les programmes démarreront après un simple ou un double clic sur l\'" +
    "image.";
            this.groupBoxView.Text = "Affichage";
            // 
            // radioButtonViewDetails
            // 
            this.radioButtonViewDetails.AutoSize = true;
            this.radioButtonViewDetails.Location = new System.Drawing.Point(106, 17);
            this.radioButtonViewDetails.Name = "radioButtonViewDetails";
            this.radioButtonViewDetails.Size = new System.Drawing.Size(57, 17);
            this.radioButtonViewDetails.TabIndex = 13;
            this.radioButtonViewDetails.Tag = "Affichage des programmes dans une liste détaillée";
            this.radioButtonViewDetails.Text = "Détails";
            this.radioButtonViewDetails.UseVisualStyleBackColor = true;
            this.radioButtonViewDetails.CheckedChanged += new System.EventHandler(this.onUISettingsChange);
            this.radioButtonViewDetails.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.radioButtonViewDetails.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.radioButtonViewDetails.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // radioButtonViewGrid
            // 
            this.radioButtonViewGrid.AutoSize = true;
            this.radioButtonViewGrid.Checked = true;
            this.radioButtonViewGrid.Location = new System.Drawing.Point(30, 17);
            this.radioButtonViewGrid.Name = "radioButtonViewGrid";
            this.radioButtonViewGrid.Size = new System.Drawing.Size(48, 17);
            this.radioButtonViewGrid.TabIndex = 12;
            this.radioButtonViewGrid.TabStop = true;
            this.radioButtonViewGrid.Tag = "Affichage des programmes dans une grille";
            this.radioButtonViewGrid.Text = "Grille";
            this.radioButtonViewGrid.UseVisualStyleBackColor = true;
            this.radioButtonViewGrid.CheckedChanged += new System.EventHandler(this.onUISettingsChange);
            this.radioButtonViewGrid.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.radioButtonViewGrid.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.radioButtonViewGrid.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // groupBoxLaunch
            // 
            this.groupBoxLaunch.Controls.Add(this.radioDoubleClic);
            this.groupBoxLaunch.Controls.Add(this.radioSimpleClic);
            this.groupBoxLaunch.Location = new System.Drawing.Point(6, 66);
            this.groupBoxLaunch.Name = "groupBoxLaunch";
            this.groupBoxLaunch.Size = new System.Drawing.Size(188, 42);
            this.groupBoxLaunch.TabIndex = 14;
            this.groupBoxLaunch.TabStop = false;
            this.groupBoxLaunch.Tag = "Choisissez si les programmes démarreront après un simple ou un double clic sur l\'" +
    "image.";
            this.groupBoxLaunch.Text = "Lancement";
            this.groupBoxLaunch.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            // 
            // radioDoubleClic
            // 
            this.radioDoubleClic.AutoSize = true;
            this.radioDoubleClic.Location = new System.Drawing.Point(101, 17);
            this.radioDoubleClic.Name = "radioDoubleClic";
            this.radioDoubleClic.Size = new System.Drawing.Size(78, 17);
            this.radioDoubleClic.TabIndex = 13;
            this.radioDoubleClic.Tag = "Les programmes démarreront après un DOUBLE clic sur l\'image.<br>En vue \"Détails\"," +
    " les programmes démarrent toujours après un double clic.";
            this.radioDoubleClic.Text = "Double clic";
            this.radioDoubleClic.UseVisualStyleBackColor = true;
            this.radioDoubleClic.CheckedChanged += new System.EventHandler(this.onChange);
            this.radioDoubleClic.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.radioDoubleClic.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.radioDoubleClic.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // radioSimpleClic
            // 
            this.radioSimpleClic.AutoSize = true;
            this.radioSimpleClic.Checked = true;
            this.radioSimpleClic.Location = new System.Drawing.Point(16, 17);
            this.radioSimpleClic.Name = "radioSimpleClic";
            this.radioSimpleClic.Size = new System.Drawing.Size(75, 17);
            this.radioSimpleClic.TabIndex = 12;
            this.radioSimpleClic.TabStop = true;
            this.radioSimpleClic.Tag = "Les programmes démarreront après un SIMPLE clic sur l\'image.<br>En vue \"Détails\"," +
    " les programmes démarrent toujours après un double clic.";
            this.radioSimpleClic.Text = "Simple clic";
            this.radioSimpleClic.UseVisualStyleBackColor = true;
            this.radioSimpleClic.CheckedChanged += new System.EventHandler(this.onChange);
            this.radioSimpleClic.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.radioSimpleClic.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.radioSimpleClic.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // checkBoxImgNames
            // 
            this.checkBoxImgNames.AutoSize = true;
            this.checkBoxImgNames.Location = new System.Drawing.Point(54, 46);
            this.checkBoxImgNames.Name = "checkBoxImgNames";
            this.checkBoxImgNames.Size = new System.Drawing.Size(106, 17);
            this.checkBoxImgNames.TabIndex = 11;
            this.checkBoxImgNames.Tag = "Vous permet d\'afficher le nom que vous avez donné à chaque programme, en dessous " +
    "de leur image respective.";
            this.checkBoxImgNames.Text = "Afficher les noms";
            this.checkBoxImgNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxImgNames.UseVisualStyleBackColor = true;
            this.checkBoxImgNames.CheckedChanged += new System.EventHandler(this.onUISettingsChange);
            this.checkBoxImgNames.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.helpRequested);
            this.checkBoxImgNames.MouseEnter += new System.EventHandler(this.ShowHelpOnHover);
            this.checkBoxImgNames.MouseLeave += new System.EventHandler(this.EraseHelp);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(15, 183);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(440, 30);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 251);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBoxItems);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonValidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImgSize)).EndInit();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            this.groupBoxLaunch.ResumeLayout(false);
            this.groupBoxLaunch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxStartup;
        private System.Windows.Forms.NumericUpDown numericUpDownImgSize;
        private System.Windows.Forms.ComboBox comboBoxShortcut1;
        private System.Windows.Forms.Label labelImgSize;
        private System.Windows.Forms.ComboBox comboBoxShortcut2;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.CheckBox checkBoxImgNames;
        private System.Windows.Forms.CheckBox checkBoxStayMinimized;
        private System.Windows.Forms.GroupBox groupBoxLaunch;
        private System.Windows.Forms.RadioButton radioDoubleClic;
        private System.Windows.Forms.RadioButton radioSimpleClic;
        private System.Windows.Forms.CheckBox checkBoxHideAfterLaunch;
        private System.Windows.Forms.CheckBox checkBoxShortcut;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.RadioButton radioButtonViewDetails;
        private System.Windows.Forms.RadioButton radioButtonViewGrid;
    }
}
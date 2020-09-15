namespace Multi_Launcher_V2
{
    partial class ItemForm
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
            this.buttonBrowseShortcut = new System.Windows.Forms.Button();
            this.textBoxShortcut = new System.Windows.Forms.TextBox();
            this.groupBoxShortcut = new System.Windows.Forms.GroupBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.buttonSelectResourceImage = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonValid = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxImgPreview = new System.Windows.Forms.PictureBox();
            this.groupBoxShortcut.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowseShortcut
            // 
            this.buttonBrowseShortcut.Location = new System.Drawing.Point(215, 18);
            this.buttonBrowseShortcut.Name = "buttonBrowseShortcut";
            this.buttonBrowseShortcut.Size = new System.Drawing.Size(28, 22);
            this.buttonBrowseShortcut.TabIndex = 0;
            this.buttonBrowseShortcut.Text = "...";
            this.buttonBrowseShortcut.UseVisualStyleBackColor = true;
            this.buttonBrowseShortcut.Click += new System.EventHandler(this.buttonBrowseShortcut_Click);
            // 
            // textBoxShortcut
            // 
            this.textBoxShortcut.Location = new System.Drawing.Point(7, 19);
            this.textBoxShortcut.Name = "textBoxShortcut";
            this.textBoxShortcut.Size = new System.Drawing.Size(200, 20);
            this.textBoxShortcut.TabIndex = 1;
            // 
            // groupBoxShortcut
            // 
            this.groupBoxShortcut.Controls.Add(this.buttonBrowseShortcut);
            this.groupBoxShortcut.Controls.Add(this.textBoxShortcut);
            this.groupBoxShortcut.Location = new System.Drawing.Point(12, 130);
            this.groupBoxShortcut.Name = "groupBoxShortcut";
            this.groupBoxShortcut.Size = new System.Drawing.Size(250, 50);
            this.groupBoxShortcut.TabIndex = 2;
            this.groupBoxShortcut.TabStop = false;
            this.groupBoxShortcut.Text = "Raccourci";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(7, 19);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(238, 21);
            this.comboCategory.TabIndex = 6;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.comboCategory);
            this.groupBoxCategory.Location = new System.Drawing.Point(12, 70);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(250, 50);
            this.groupBoxCategory.TabIndex = 3;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Catégorie";
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.buttonSelectResourceImage);
            this.groupBoxImage.Controls.Add(this.buttonExtract);
            this.groupBoxImage.Controls.Add(this.buttonBrowseImage);
            this.groupBoxImage.Controls.Add(this.textBoxImagePath);
            this.groupBoxImage.Location = new System.Drawing.Point(12, 190);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(250, 70);
            this.groupBoxImage.TabIndex = 3;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Image";
            // 
            // buttonSelectResourceImage
            // 
            this.buttonSelectResourceImage.Location = new System.Drawing.Point(177, 42);
            this.buttonSelectResourceImage.Name = "buttonSelectResourceImage";
            this.buttonSelectResourceImage.Size = new System.Drawing.Size(68, 23);
            this.buttonSelectResourceImage.TabIndex = 4;
            this.buttonSelectResourceImage.Text = "Resources";
            this.buttonSelectResourceImage.UseVisualStyleBackColor = true;
            this.buttonSelectResourceImage.Click += new System.EventHandler(this.buttonSelectResourceImage_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(84, 42);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(85, 23);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "Extraire icône";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtractImgFromShortcut_Click);
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.AutoSize = true;
            this.buttonBrowseImage.Location = new System.Drawing.Point(7, 42);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(68, 23);
            this.buttonBrowseImage.TabIndex = 0;
            this.buttonBrowseImage.Text = "Parcourir";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(8, 18);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.ReadOnly = true;
            this.textBoxImagePath.Size = new System.Drawing.Size(236, 20);
            this.textBoxImagePath.TabIndex = 1;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxName);
            this.groupBoxName.Location = new System.Drawing.Point(12, 10);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(250, 50);
            this.groupBoxName.TabIndex = 3;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Nom de l\'élément";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(7, 19);
            this.textBoxName.MaxLength = 20;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(40, 330);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(75, 23);
            this.buttonValid.TabIndex = 4;
            this.buttonValid.Text = "Valider";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(160, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBoxImgPreview
            // 
            this.pictureBoxImgPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImgPreview.Location = new System.Drawing.Point(113, 270);
            this.pictureBoxImgPreview.Name = "pictureBoxImgPreview";
            this.pictureBoxImgPreview.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxImgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImgPreview.TabIndex = 6;
            this.pictureBoxImgPreview.TabStop = false;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 361);
            this.Controls.Add(this.pictureBoxImgPreview);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.groupBoxName);
            this.Controls.Add(this.groupBoxImage);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.groupBoxShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un élément";
            this.groupBoxShortcut.ResumeLayout(false);
            this.groupBoxShortcut.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxImage.ResumeLayout(false);
            this.groupBoxImage.PerformLayout();
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowseShortcut;
        private System.Windows.Forms.TextBox textBoxShortcut;
        private System.Windows.Forms.GroupBox groupBoxShortcut;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxImgPreview;
        private System.Windows.Forms.Button buttonSelectResourceImage;
    }
}
namespace Multi_Launcher_V2
{
    partial class ItemComponent
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.labelItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureItem
            // 
            this.pictureItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureItem.Location = new System.Drawing.Point(3, 3);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(100, 100);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 0;
            this.pictureItem.TabStop = false;
            // 
            // labelItem
            // 
            this.labelItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelItem.AutoEllipsis = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelItem.Location = new System.Drawing.Point(3, 110);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(100, 25);
            this.labelItem.TabIndex = 2;
            this.labelItem.Text = "label";
            this.labelItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelItem.UseCompatibleTextRendering = true;
            // 
            // ItemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureItem);
            this.Controls.Add(this.labelItem);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ItemComponent";
            this.Size = new System.Drawing.Size(106, 140);
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureItem;
        private System.Windows.Forms.Label labelItem;
    }
}

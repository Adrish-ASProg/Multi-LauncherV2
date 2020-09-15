using Multi_Launcher_V2.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace Multi_Launcher_V2 {
    public partial class ResourcesForm : Form {
        public Image selectedImage;
        public string selectedImageId;

        public bool shouldRefreshUI;
        private bool selectMode;

        public ResourcesForm(bool selectMode) {
            InitializeComponent();

            this.selectMode = selectMode;
            this.shouldRefreshUI = false;
            SetupUi();
        }

        private void SetupUi() {

            Icon = Icon.FromHandle(Resources.image.GetHicon());

            if (selectMode) Text = "Sélectionnez une image";

            try {
                layoutPanel.Controls.Clear();

                var node = new ResXResourceReader("resources.resx").GetEnumerator();

                while (node.MoveNext()) {
                    var pictureBox = new PictureBox {
                        Image = (Bitmap) node.Value,
                        Tag = node.Key.ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(75, 75)
                    };
                    pictureBox.MouseClick += new MouseEventHandler(pictureBoxes_MouseClick);

                    if (selectMode) pictureBox.Cursor = Cursors.Hand;

                    layoutPanel.Controls.Add(pictureBox);
                }
            } catch (Exception e) {
                Console.WriteLine("Error reading resources: " + e);
            }
        }

        private void RemovePictureBoxByTag(string tag) {
            var pictureBox = layoutPanel.Controls
                .Cast<Control>()
                .First(control => Equals(control.Tag.ToString(), tag));

            layoutPanel.Controls.Remove(pictureBox);
        }

        private void pictureBoxes_MouseClick(object sender, MouseEventArgs e) {
            var pictureBox = (PictureBox) sender;

            if (selectMode && e.Button == MouseButtons.Left) {
                selectedImage = pictureBox.Image;
                selectedImageId = pictureBox.Tag.ToString();
                DialogResult = DialogResult.OK;
                Close();
            } else if (e.Button == MouseButtons.Right) {
                toolStripMenuItemDelete.Tag = pictureBox.Tag;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e) {
            var tag = ((ToolStripMenuItem) sender).Tag.ToString();
            DialogResult r = MessageBox.Show("Voulez vous vraiment supprimer cette image ?\nID: " + tag,
                "Confirmation de suppression", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (r != DialogResult.Yes) return;

            FileManager.RemoveResource(tag);
            RemovePictureBoxByTag(tag);
            shouldRefreshUI = true;
        }
    }
}

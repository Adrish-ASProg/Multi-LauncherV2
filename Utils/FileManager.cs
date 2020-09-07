using System;
using System.IO;
using IWshRuntimeLibrary;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Collections;
using Multi_Launcher_V2.Properties;
using System.Collections.Generic;

namespace Multi_Launcher_V2 {
    class FileManager {

        public static void CreateApplicationShortcut(string destPath) {
            FileInfo f = new FileInfo(Application.ExecutablePath);

            if (System.IO.File.Exists(destPath))
                System.IO.File.Delete(destPath);

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut) shell.CreateShortcut(destPath);
            shortcut.TargetPath = Application.ExecutablePath.ToString();
            shortcut.WorkingDirectory = f.DirectoryName;
            shortcut.Save();
        }

        public static Bitmap ExtractIcon(string filePath) {
            Bitmap bmp = null;

            try {
                bmp = Icon.ExtractAssociatedIcon(filePath).ToBitmap();
            } catch (Exception) { }

            return bmp;
        }

        public static void RemoveResource(string resEntryKey) {
            using (ResXResourceReader reader = new ResXResourceReader("resources.resx")) {
                using (ResXResourceWriter writer = new ResXResourceWriter("resources.resx")) {
                    IDictionaryEnumerator de = reader.GetEnumerator();
                    while (de.MoveNext()) {
                        if (!de.Entry.Key.ToString().Equals(resEntryKey, StringComparison.InvariantCultureIgnoreCase)) {
                            writer.AddResource(de.Entry.Key.ToString(), (Bitmap) de.Entry.Value);
                        }
                    }
                    writer.Close();
                }
                reader.Close();
            }
        }

        public static bool AddImageToResources(string name, Image img) {
            try {
                var reader = new ResXResourceReader("resources.resx");
                var writer = new ResXResourceWriter("resources.resx");
                var node = reader.GetEnumerator();

                var nodeKeys = new List<String>();

                while (node.MoveNext()) {
                    var nodeKey = node.Key.ToString();
                    nodeKeys.Add(nodeKey);
                    writer.AddResource(nodeKey, (Bitmap) node.Value);
                }

                if (!nodeKeys.Contains(name)) {
                    writer.AddResource(name, img);
                }

                writer.Generate();
                writer.Close();
            } catch {
                return false;
            }

            return true;
        }

        public static Bitmap GetImgFromResource(string name) {
            ResXResourceReader resReader = new ResXResourceReader("resources.resx");

            foreach (DictionaryEntry d in resReader) {
                if (d.Key.ToString().Equals(name)) {
                    resReader.Close();
                    return (Bitmap) d.Value;
                }
            }
            resReader.Close();
            return (Bitmap) Resources.ResourceManager.GetObject("defaultImg", Resources.Culture);
        }

        public static Image ResizeImage(Image originalImage) {
            int largestDimension = Math.Max(originalImage.Height, originalImage.Width);
            Size squareSize = new Size(largestDimension, largestDimension);
            Bitmap squareImage = new Bitmap(squareSize.Width, squareSize.Height);
            using (Graphics graphics = Graphics.FromImage(squareImage)) {
                graphics.FillRectangle(Brushes.Transparent, 0, 0, squareSize.Width, squareSize.Height);
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                graphics.DrawImage(originalImage, (squareSize.Width / 2) - (originalImage.Width / 2), (squareSize.Height / 2) - (originalImage.Height / 2), originalImage.Width, originalImage.Height);
            }
            return squareImage;
        }
    }
}

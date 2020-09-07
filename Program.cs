using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace Multi_Launcher_V2 {
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsRunning()) {
                var errorMsg = $"Erreur, {Process.GetCurrentProcess().ProcessName} est déjà lancé.\nCette instance va se quitter.";
                MessageBox.Show(errorMsg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileManager.CreateResourcesFile();

            Application.Run(new MainForm());
        }

        private static bool IsRunning() {
            return Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1;
        }
    }
}

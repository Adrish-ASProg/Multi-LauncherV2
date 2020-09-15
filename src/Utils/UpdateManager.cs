using AutoUpdaterDotNET;

using System;
using System.IO;
using System.Windows.Forms;

namespace Multi_Launcher_V2.Utils {
    class UpdateManager {


        public static void CheckForUpdate(bool startup) {
            if (!startup) {
                AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            }

            var currentDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            if (currentDirectory != null) {
                //AutoUpdater.InstallationPath = currentDirectory.Parent.FullName;
                AutoUpdater.InstallationPath = currentDirectory.FullName;
            }

            AutoUpdater.ShowRemindLaterButton = true;
            AutoUpdater.ShowSkipButton = true;
            AutoUpdater.LetUserSelectRemindLater = true;
            AutoUpdater.OpenDownloadPage = false;
            AutoUpdater.ReportErrors = true;
            AutoUpdater.Start("https://raw.githubusercontent.com/Adrish-ASProg/Multi-LauncherV2/master/AutoUpdater.xml");
        }



        private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args) {
            if (args == null) {
                MessageBox.Show(
                        @"Impossible d'obtenir les informations de mise à jour, veuillez vérifier votre connexion ou le statut du serveur.",
                        @"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!args.IsUpdateAvailable) {
                MessageBox.Show(@"Aucune mise à jour disponible, vous disposez de la dernière version en ligne.", @"Aucune mise à jour",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            var message = $@"Multi-Launcher version {args.CurrentVersion} est désormais disponible.{Environment.NewLine}" +
                        $@"(Vous disposez de la version {args.InstalledVersion}){Environment.NewLine}";

            if (args.Mandatory.Value) {
                message += $@"Il s'agit d'une mise à jour obligatoire, vous ne pouvez continuer sans.{Environment.NewLine}";
            }

            var dialogResult = MessageBox.Show(message +
                    $@"Appuyer sur OK pour démarrer le téléchargement", "Mise à Jour disponible",
                    args.Mandatory.Value ? MessageBoxButtons.OKCancel : MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);


            if (dialogResult.Equals(DialogResult.Cancel)) {
                Environment.Exit(0);
            }

            if (dialogResult.Equals(DialogResult.Yes)) {
                try {
                    if (AutoUpdater.DownloadUpdate(args)) {
                        Application.Exit();
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            AutoUpdater.CheckForUpdateEvent -= AutoUpdaterOnCheckForUpdateEvent;
        }

    }
}

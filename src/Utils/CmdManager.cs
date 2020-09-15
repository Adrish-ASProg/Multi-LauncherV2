using System.Diagnostics;

namespace Multi_Launcher_V2.Utils {
    public static class CmdManager {

        public static void ExecuteCommand(string command) {
            Process proc = new Process();
            proc.StartInfo.FileName = command;
            proc.Start();
        }
    }
}

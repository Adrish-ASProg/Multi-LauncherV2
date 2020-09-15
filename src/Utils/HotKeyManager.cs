
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Multi_Launcher_V2.Utils {
    public static class HotKeyManager {

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private static Dictionary<Keys, int> HotKeyModifiersMap = new Dictionary<Keys, int> {
            { Keys.Alt, 1 },
            { Keys.Control, 2 },
            { Keys.Shift, 4 }
        };

        private static int HOTKEY_ID = 1;


        public static void InitializeHotKey(IntPtr handle, Keys shortcutModifier, Keys shortcutKey) {
            if (shortcutModifier == Keys.None || shortcutKey == Keys.None) {
                UnregisterHotKey(handle, HOTKEY_ID);
                return;
            }

            int hotKeyModifier = HotKeyModifiersMap[shortcutModifier];
            int hotKeyCode = (int) shortcutKey;

            UnregisterHotKey(handle, HOTKEY_ID);
            var registeredHotkey = RegisterHotKey(handle, HOTKEY_ID, hotKeyModifier, hotKeyCode);

            if (!registeredHotkey) ShowError();

            Console.WriteLine($"Registered hotkey for handle {handle}");
        }

        public static void UnregisterHotKey(IntPtr handle) {
            Console.WriteLine($"Unregistered hotkey for handle {handle}");
            UnregisterHotKey(handle, HOTKEY_ID);
        }


        private static void ShowError() {
            MessageBox.Show("Impossible d'assigner le raccourci clavier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

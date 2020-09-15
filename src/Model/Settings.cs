
using System.Windows.Forms;

namespace Multi_Launcher_V2.Model {

    public class Settings {
        public bool Startup { get; set; }
        public int imgSize { get; set; }
        public bool names { get; set; }
        public Keys shortcutModifier { get; set; }
        public Keys shortcutKey { get; set; }
        public bool doubleClick { get; set; }
        public bool stayMinimized { get; set; }
        public bool hideAfterLaunch { get; set; }
        public bool detailsView { get; set; }

        public Settings() {
            Startup = false;
            imgSize = 70;
            names = false;
            shortcutModifier = Keys.None;
            shortcutKey = Keys.None;
            doubleClick = false;
            stayMinimized = false;
            hideAfterLaunch = false;
            detailsView = false;
        }
    }
}

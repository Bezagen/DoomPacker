using DoomPacker.Backend;
using System.Configuration;
using System.Data;
using System.IO;
using System.Security.Policy;
using System.Windows;

namespace DoomPacker
{
    public partial class App : Application
    {
        public static Settings AppSettings { get; set; }
        
        public string _DefaultSettingsPath = 
            AppDomain.CurrentDomain.BaseDirectory + @"\Settings\DefaultSettings.xml";

        public string _UserSettingsPath =
            AppDomain.CurrentDomain.BaseDirectory + @"\Settings\UserSettings.xml";

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if (File.Exists(_UserSettingsPath))
                AppSettings = Settings.Read(_UserSettingsPath);
            else
                AppSettings = Settings.Read(_DefaultSettingsPath);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            AppSettings.ModsFolder = "Mods";
            if (File.Exists(_UserSettingsPath))
                AppSettings.Save(_UserSettingsPath);
            else
                AppSettings.Save(_DefaultSettingsPath);
            
            base.OnExit(e);
        }
    }

}

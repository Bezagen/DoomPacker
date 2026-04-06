using DoomPacker.Backend;
using System.Configuration;
using System.Data;
using System.Security.Policy;
using System.Windows;

namespace DoomPacker
{
    public partial class App : Application
    {
        public Settings AppSettings { get; set; }
        
        public string _DefaultSettingsPath = 
            AppDomain.CurrentDomain.BaseDirectory + @"\Settings\DefaultSettings.xml";

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppSettings = Settings.Read(_DefaultSettingsPath);
        }
    }

}

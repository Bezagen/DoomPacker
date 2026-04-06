using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoomPacker.Backend
{
    public class Settings
    {
        public string PackIconPath { get; set; } = "pack://application:,,,/Icons/";
        public string ModPackFolder { get; set; } = "ModPacks";
        public string LoadOrderListsFolder { get; set; } = "LoadOrders";

        public void Save(string fileName)
        {
            if (File.Exists(fileName))
            {
                Debug.WriteLine("FileExist");
                using StreamWriter streamWriter = new(fileName);
                XmlSerializer xmlSerializer = new(typeof(Settings));
                xmlSerializer.Serialize(streamWriter, this);
            }
            else
            {
                Debug.WriteLine("Nope");
                File.Create(fileName);
            }
        }

        public static Settings Read(string fileName)
        {
            using (StreamReader streamReader = new(fileName))
            {
                XmlSerializer xmlSerializer = new(typeof(Settings));
                return xmlSerializer.Deserialize(streamReader) as Settings;
            }
        }
    }
}

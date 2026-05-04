using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace DoomPacker.Backend
{
    public class Settings
    {
        public string PackIconPath { get; set; }
        public string ModPackFolder { get; set; }
        public string LoadOrderListsFolder { get; set; }
        public string ModsFolder { get; set; }

        public void Save(string fileName)
        {
            Debug.WriteLine("FileExist");
            using StreamWriter streamWriter = new(fileName);
            XmlSerializer xmlSerializer = new(typeof(Settings));
            xmlSerializer.Serialize(streamWriter, this);
        }

        public static Settings Read(string fileName)
        {
            using StreamReader streamReader = new(fileName);
            XmlSerializer xmlSerializer = new(typeof(Settings));
            return xmlSerializer.Deserialize(streamReader) as Settings;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomPacker.Backend
{
    public class FileManager
    {
        private string modsFolder;
        public FileManager(string ModsFolder) 
        {
            modsFolder = ModsFolder;
        }

        public List<string> FindModsInDirectory()
        {
            List<string> modsList = [];

            var directory = new DirectoryInfo(modsFolder);

            if (directory.Exists)
            {
                FileInfo[] mods = directory.GetFiles();

                foreach ( FileInfo mod in mods )
                {
                    if (mod.Name.EndsWith(".pk3") || mod.Name.EndsWith(".wad"))
                        modsList.Add(mod.FullName);
                }
            }

            return modsList;
        }
    }
}

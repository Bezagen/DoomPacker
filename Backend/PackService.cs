using DoomPacker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoomPacker.Backend
{
    public class PackService
    {
        public void CreateModPack(string title, string image, string port, List<ModPackModel> modsPaths) 
        {
            XDocument xModPack = new XDocument();
            XElement pack = new XElement("pack");
            XAttribute packAttr = new XAttribute("title", title);
            XElement packImage = new XElement("image", image);
            XElement packPort = new XElement("port", port);
            
            pack.Add(packAttr);
            pack.Add(packImage);
            pack.Add(packPort);

            for (int i = 0; i < modsPaths.Count; i++)
            {
                XElement packMod = new XElement("mod", modsPaths[i]);
                pack.Add(packMod);
            }

            xModPack.Add(pack);
            xModPack.Save($"{title}.xml");
        }
    }
}

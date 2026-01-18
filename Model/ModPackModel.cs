using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoomPacker.Model
{
    public class ModPackModel : INotifyPropertyChanged
    {
        private string title;
        private string doomPortPath;
        private List<string> modsPaths;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string DoomPortPath
        {
            get { return doomPortPath; }
            set
            {
                doomPortPath = value;
                OnPropertyChanged("DoomPortPath");
            }
        }

        public List<string> ModsPaths
        {
            get { return modsPaths; }
            set 
            { 
                modsPaths = value;
                OnPropertyChanged("ModsPaths");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

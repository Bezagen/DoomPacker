using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoomPacker.Model
{
    public class ModPackContent : ModPackInfo, INotifyPropertyChanged
    {
        private string? description;
        private List<string> modsOrder;

        public string Description
        {
            get { return description; }
            set 
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public List<string> ModsOrder
        {
            get { return modsOrder; }
            set
            {
                modsOrder = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

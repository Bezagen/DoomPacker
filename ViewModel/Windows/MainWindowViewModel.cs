using DoomPacker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoomPacker.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ModPackModel selectedModPack;
        public ObservableCollection<ModPackModel> ModPacks { get; set; }

        public ModPackModel SelectedModPack
        {
            get { return selectedModPack; }
            set
            {
                selectedModPack = value;
                OnPropertyChanged("SelectedModPack");
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

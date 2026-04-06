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
        private Object selectedModPack;
        public ObservableCollection<Object> Collection { get; set; }

        public Object SelectedModPack
        {
            get { return selectedModPack; }
            set
            {
                selectedModPack = value;
                OnPropertyChanged("SelectedModPack");
            }
        }

        public MainWindowViewModel()
        {
            Collection = [
                new ModPackInfo { Title = "ModPack 1", Version = "0,1", Path = "Null" },
                new LoadOrderList {Title = "LoadOrderList", Path = "Null"}
                ];
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

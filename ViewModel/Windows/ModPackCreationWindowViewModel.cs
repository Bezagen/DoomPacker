using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoomPacker.ViewModel.Windows
{
    public class ModPackCreationWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> ModsInFolder { get; set; };

        public ModPackCreationWindowViewModel()
        {
            
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

using DoomPacker.Backend;
using HandyControl.Tools.Command;
using HandyControl.Tools.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DoomPacker.ViewModel.Windows
{
    public class ModPackCreationWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> ModsInFolder { get; set; }
        public ObservableCollection<string> ModsInModPack { get; set; }
        public ICommand FolderDoubleClickCommand { get; }
        public ICommand PackDoubldeClickCommand { get; }

        private FileManager fileManager = new();
        private object _selectedItemFolder;
        private object _selectedItemPack;

        public ModPackCreationWindowViewModel()
        {
            FolderDoubleClickCommand = new RelayCommand<object>(OnDoubleClickFolder);
            PackDoubldeClickCommand = new RelayCommand<object>(OnDoubleClickPack);
            
            ModsInFolder = new(fileManager.FindModsInDirectory());
            ModsInModPack = [];
        }

        public object SelectedItemFolder
        {
            get => _selectedItemFolder;
            set
            {
                _selectedItemFolder = value;
                OnPropertyChanged();
            }
        }

        public object SelectedItemPack
        {
            get => _selectedItemPack;
            set
            {
                _selectedItemPack = value;
                OnPropertyChanged();
            }
        }

        private void OnDoubleClickFolder(object parameter)
        {
            var item = parameter ?? SelectedItemFolder;

            ModsInFolder.DeleteIfExists(item.ToString());
            ModsInModPack.Add(item.ToString());
        }

        private void OnDoubleClickPack(object parameter)
        {
            var item = parameter ?? SelectedItemPack;

            ModsInModPack.DeleteIfExists(item.ToString());
            ModsInFolder.Add(item.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

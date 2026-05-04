using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DoomPacker;
using System.Threading.Tasks;

namespace DoomPacker.Model
{
    public class LoadOrderList : INotifyPropertyChanged
    {
        private string title;
        private string path;
        private string image = App.AppSettings.PackIconPath;

        public string Title
        {
            get {  return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Path
        {
            get { return path; }
            set
            {
                path = value; 
                OnPropertyChanged("Path");
            }
        }

        public string Image
        {
            get => image;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

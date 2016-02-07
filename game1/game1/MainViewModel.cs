using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _val = "beleberda!";

        public string Val
        {
            get
            {
                return _val;
            }
            set
            {
                _val = value;
                OnPropertyChanged("Val");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }// make sure only to call this if the value actually changes
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    public class Model:INotifyPropertyChanged
    {
        private string _ten;

        public string Ten
        {
            get => _ten; set
            {
                if (_ten!=value)
                {
                    _ten = value;
                    OnPropertyChanged("Ten");
                }
                
            }
                    
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

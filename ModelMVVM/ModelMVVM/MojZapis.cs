using System;
using System.Collections.Generic;
using System.ComponentModel;
using Windows.UI;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModelMVVM
{
    class MojZapis : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value;
                  this.OnPropertyChanged();
            }
        }
        private Color barva;
        public Color Barva
        {
            get { return barva; }
            set { barva = value;
                this.OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

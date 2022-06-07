using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Windows.UI;

namespace ModelMVVM
{
    class MyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ObservableCollection<MojZapis> Zapisi { get; set; }
        public string Naslov { get; set; }
        private MojZapis trenutni;
        public MojZapis Trenutni {
            get { return trenutni; }
            set { trenutni = value;
                this.OnPropertyChanged();
                NarediZeleno.RaiseCanExecuteChanged();
            }
        }
        public DelegateCommand NarediZeleno { get; set; }

        public MyViewModel()
        {
            Zapisi = new ObservableCollection<MojZapis>();
            for (int k = 0; k < 10; k++)
            {
                Zapisi.Add(new MojZapis() { Ime = k.ToString(), Barva = Windows.UI.Color.FromArgb(255,255,165,0) });
            }
            Naslov = "Moji zapiski";
            NarediZeleno = new DelegateCommand(
                (p) => { Trenutni.Barva = Color.FromArgb(255, 0, 255, 0); },
                (p) => { return Trenutni != null; }
                );
            Trenutni = Zapisi.First();
            
        }
    }
}

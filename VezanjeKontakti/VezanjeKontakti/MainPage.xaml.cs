using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VezanjeKontakti
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Icon> ikone;
        public MainPage()
        {
            this.InitializeComponent();
            ikone = new List<Icon>();
            ikone.Add(new Icon { IkonaPot = "Assets/male-01.png" });
            ikone.Add(new Icon { IkonaPot = "Assets/male-02.png" });
            ikone.Add(new Icon { IkonaPot = "Assets/male-03.png" });
            ikone.Add(new Icon { IkonaPot = "Assets/female-01.png" });
            ikone.Add(new Icon { IkonaPot = "Assets/female-02.png" });
            ikone.Add(new Icon { IkonaPot = "Assets/female-03.png" });

        }
    }
}

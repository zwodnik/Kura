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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Kura
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Random _random;

        public MainPage()
        {
            this.InitializeComponent();

            _random = new Random();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kawal;
            do{
                kawal = DataBase.Hasla()[_random.Next(0,DataBase.Hasla().Count)];
            } while(kawalTextBlock.Text == kawal);

            kawalTextBlock.Text = kawal;

            suchosc.Text = String.Format("Suche na {0:P0}", _random.NextDouble() * 3);

            bleep.Play();
        }

    }
}

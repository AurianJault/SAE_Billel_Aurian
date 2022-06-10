using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Agent
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new PagePrincipale();
        }
        private void ClickTwitter(object sender, EventArgs e)
        {
            var uri = "https://mobile.twitter.com/playvalorant?lang=fr";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
        private void ClickFB(object sender, EventArgs e)
        {
            var uri = "https://www.facebook.com/VALORANTfr/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
        private void clickControlleur(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl2();
        }
        private void clickDuelliste(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
        private void clickSentinelle(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl3();
        }
        private void ClickSky(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new USJett("Skye");
        }
        private void ClickSova(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new USJett("Sova");
        }
        private void ClickBreach(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new USJett("Breach");
        }
        private void ClickKayo(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new USJett("KAY/O");
        }
        private void ClickFade(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new USJett("Fade");
        }
    }
}

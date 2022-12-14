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
    /// Logique d'interaction pour UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
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
            page.Content = new UserControl2();
        }
        private void clickDuelliste(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl4();
        }
        private void clickInitiateur(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl1();
        }


        private void Menu(object sender, RoutedEventArgs e)
        {
            page.Content = new PagePrincipale();
        }
        private void ClickSage(object sender, RoutedEventArgs e)
        {
            page.Content = new USJett("Sage");

        }
        private void ClickChamber(object sender, RoutedEventArgs e)
        {
            page.Content = new USJett("Chamber");

        }
        private void ClickCypher(object sender, RoutedEventArgs e)
        {
            page.Content = new USJett("Cypher");

        }
        private void ClickKJ(object sender, RoutedEventArgs e)
        {
            page.Content = new USJett("Killjoy");

        }
    }
}

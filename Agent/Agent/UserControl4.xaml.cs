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
    /// Logique d'interaction pour UserControl4.xaml
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        private void clickInitiateur(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new UserControl1();
        }
        private void clickControlleur(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new UserControl2();
        }
        private void clickSentinelle(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new UserControl3();
        }
        private void ClickNeon(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new USJett("Neon");
        }
        
        private void ClickReyna(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new USJett("Reyna");

        }
        private void ClickPhoenix(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new USJett("Phoenix");

        }
        private void ClickJett(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new USJett("Jett");

        }
        private void ClickYoru(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new USJett("Yoru");

        }
        private void ClickRaze(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new USJett("Raze");

        }
        private void ClickMenu(object sender, RoutedEventArgs e)
        {
            Duellist.Content = new PagePrincipale();

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
    }
}

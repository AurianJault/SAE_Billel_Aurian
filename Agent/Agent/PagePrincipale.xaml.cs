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
    /// Logique d'interaction pour PagePrincipale.xaml
    /// </summary>
    public partial class PagePrincipale : UserControl
    {
        public PagePrincipale()
        {
            InitializeComponent();
        }
        private void Agents(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl4();
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
        private void Regle(object sender, RoutedEventArgs e)
        {
            page.Content = new PageRegle();
        }
        
    }
}

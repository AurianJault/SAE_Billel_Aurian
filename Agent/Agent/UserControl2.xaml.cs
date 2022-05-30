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
using System.Diagnostics;


namespace Agent
{
    /// <summary>
    /// Logique d'interaction pour UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }


        private void clickInitiateur(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl1();
        }
        private void clickDuelliste(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl4();
        }
        private void clickSentinelle(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl3();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            page.Content = new PagePrincipale();
        }

        
        private void ClickTwitter(object sender, EventArgs e)
        {
            /*System.Diagnostics.Process.Start("https://jira.dsi.uca.fr/plugins/servlet/desk/portal/29");*/

        }


        private void ClickAstra(object sender, RoutedEventArgs e)
        {
            page.Content = new USAstra();
        }
        private void ClickBrim(object sender, RoutedEventArgs e)
        {
            page.Content = new USBrim();

        }
        private void ClickOmen(object sender, RoutedEventArgs e)
        {
            page.Content = new USOmen();

        }
        private void ClickViper(object sender, RoutedEventArgs e)
        {
            page.Content = new USViper();

        }
    }
}

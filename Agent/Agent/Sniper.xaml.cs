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
    /// Logique d'interaction pour Sniper.xaml
    /// </summary>
    public partial class Sniper : UserControl
    {
        public Sniper()
        {
            InitializeComponent();
        }

        private void Menu(object sender, RoutedEventArgs e)
        {
            page.Content = new PagePrincipale();
        }


        private void ClickFAP(object sender, RoutedEventArgs e)
        {
            page.Content = new FAP();

        }
        private void ClickF(object sender, RoutedEventArgs e)
        {
            page.Content = new Fusil();

        }
        private void ClickA(object sender, RoutedEventArgs e)
        {
            page.Content = new PageArmes();

        }
        private void PM(object sender, RoutedEventArgs e)
        {
            page.Content = new PM();

        }
    }
}

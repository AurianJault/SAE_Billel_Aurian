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
    /// Logique d'interaction pour USViper.xaml
    /// </summary>
    public partial class USViper : UserControl
    {
        public USViper()
        {
            InitializeComponent();
        }
        private void A(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ViperSpellA();
        }
        private void E(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ViperSpellE();
        }
        private void C(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ViperSpellC();
        }
        private void X(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ViperSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl2();
        }
    }
}

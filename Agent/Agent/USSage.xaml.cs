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
    /// Logique d'interaction pour USSage.xaml
    /// </summary>
    public partial class USSage : UserControl
    {
        public USSage()
        {
            InitializeComponent();
        }
        private void ASage(object sender, RoutedEventArgs e)
        {
            Spell.Content = new SageSpellA();
        }
        private void ESage(object sender, RoutedEventArgs e)
        {
            Spell.Content = new SageSpellE();
        }
        private void CSage(object sender, RoutedEventArgs e)
        {
            Spell.Content = new SageSpellC();
        }
        private void XSage(object sender, RoutedEventArgs e)
        {
            Spell.Content = new SageSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

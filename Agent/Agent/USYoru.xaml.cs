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
    /// Logique d'interaction pour USYoru.xaml
    /// </summary>
    public partial class USYoru : UserControl
    {
        public USYoru()
        {
            InitializeComponent();
        }
        private void AYoru(object sender, RoutedEventArgs e)
        {
            Spell.Content = new YoruSpellA();
        }
        private void EYoru(object sender, RoutedEventArgs e)
        {
            Spell.Content = new YoruSpellE();
        }
        private void CYoru(object sender, RoutedEventArgs e)
        {
            Spell.Content = new YoruSpellC();
        }
        private void XYoru(object sender, RoutedEventArgs e)
        {
            Spell.Content = new YoruSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

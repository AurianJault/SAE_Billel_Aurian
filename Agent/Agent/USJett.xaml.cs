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
    /// Logique d'interaction pour USJett.xaml
    /// </summary>
    public partial class USJett : UserControl
    {
        public USJett()
        {
            InitializeComponent();
        }
        private void AJett(object sender, RoutedEventArgs e)
        {
            Spell.Content = new JettSpellA();
        }
        private void EJett(object sender, RoutedEventArgs e)
        {
            Spell.Content = new JettSpellE();
        }
        private void CJett(object sender, RoutedEventArgs e)
        {
            Spell.Content = new JettSpellC();
        }
        private void XJett(object sender, RoutedEventArgs e)
        {
            Spell.Content = new JettSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

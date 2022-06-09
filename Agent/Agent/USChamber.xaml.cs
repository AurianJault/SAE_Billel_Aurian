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
    /// Logique d'interaction pour USChamber.xaml
    /// </summary>
    public partial class USChamber : UserControl
    {
        public USChamber()
        {
            InitializeComponent();
        }
        private void AChamber(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ChamberSpellA();
        }
        private void EChamber(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ChamberSpellE();
        }
        private void CChamber(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ChamberSpellC();
        }
        private void XChamber(object sender, RoutedEventArgs e)
        {
            Spell.Content = new ChamberSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl3();
        }
    }
}

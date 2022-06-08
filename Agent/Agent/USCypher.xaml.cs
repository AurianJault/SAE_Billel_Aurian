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
    /// Logique d'interaction pour USCypher.xaml
    /// </summary>
    public partial class USCypher : UserControl
    {
        public USCypher()
        {
            InitializeComponent();
        }
        private void ACypher(object sender, RoutedEventArgs e)
        {
            Spell.Content = new CypherSpellA();
        }
        private void ECypher(object sender, RoutedEventArgs e)
        {
            Spell.Content = new CypherSpellE();
        }
        private void CCypher(object sender, RoutedEventArgs e)
        {
            Spell.Content = new CypherSpellC();
        }
        private void XCypher(object sender, RoutedEventArgs e)
        {
            Spell.Content = new CypherSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

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
    /// Logique d'interaction pour USPhoenix.xaml
    /// </summary>
    public partial class USPhoenix : UserControl
    {
        public USPhoenix()
        {
            InitializeComponent();
        }
        private void APhoenix(object sender, RoutedEventArgs e)
        {
            Spell.Content = new PhoenixSpellA();
        }
        private void EPhoenix(object sender, RoutedEventArgs e)
        {
            Spell.Content = new PhoenixSpellE();
        }
        private void CPhoenix(object sender, RoutedEventArgs e)
        {
            Spell.Content = new PhoenixSpellC();
        }
        private void XPhoenix(object sender, RoutedEventArgs e)
        {
            Spell.Content = new PhoenixSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

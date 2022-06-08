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
    /// Logique d'interaction pour USAstra.xaml
    /// </summary>
    public partial class USAstra : UserControl
    {
        public USAstra()
        {
            InitializeComponent();
        }
        private void AAstra(object sender, RoutedEventArgs e)
        {
            Spell.Content = new AstraSpellA();
        }
        private void EAstra(object sender, RoutedEventArgs e)
        {
            Spell.Content = new AstraSpellE();
        }
        private void CAstra(object sender, RoutedEventArgs e)
        {
            Spell.Content = new AstraSpellC();
        }
        private void XAstra(object sender, RoutedEventArgs e)
        {
            Spell.Content = new AstraSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl2();
        }
    }
}

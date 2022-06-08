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
    /// Logique d'interaction pour USRaze.xaml
    /// </summary>
    public partial class USRaze : UserControl
    {
        public USRaze()
        {
            InitializeComponent();
        }
        private void ARaze(object sender, RoutedEventArgs e)
        {
            Spell.Content = new RazeSpellA();
        }
        private void ERaze(object sender, RoutedEventArgs e)
        {
            Spell.Content = new RazeSpellE();
        }
        private void CRaze(object sender, RoutedEventArgs e)
        {
            Spell.Content = new RazeSpellC();
        }
        private void XRaze(object sender, RoutedEventArgs e)
        {
            Spell.Content = new RazeSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

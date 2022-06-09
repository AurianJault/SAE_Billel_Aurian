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
    /// Logique d'interaction pour USFade.xaml
    /// </summary>
    public partial class USFade : UserControl
    {
        public USFade()
        {
            InitializeComponent();
        }
        private void A(object sender, RoutedEventArgs e)
        {
            Spell.Content = new FadeSpellA();
        }
        private void E(object sender, RoutedEventArgs e)
        {
            Spell.Content = new FadeSpellE();
        }
        private void C(object sender, RoutedEventArgs e)
        {
            Spell.Content = new FadeSpellC();
        }
        private void X(object sender, RoutedEventArgs e)
        {
            Spell.Content = new FadeSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl1();
        }
    }
}

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
    /// Logique d'interaction pour USBrim.xaml
    /// </summary>
    public partial class USBrim : UserControl
    {
        public USBrim()
        {
            InitializeComponent();
        }
        private void ASpell(object sender, RoutedEventArgs e)
        {
            Spell.Content = new BrimSpellA();
        }
        private void ESpell(object sender, RoutedEventArgs e)
        {
            Spell.Content = new BrimSpellE();
        }
        private void CSpell(object sender, RoutedEventArgs e)
        {
            Spell.Content = new BrimSpellC();
        }
        private void XSpell(object sender, RoutedEventArgs e)
        {
            Spell.Content = new BrimSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl2();
        }
    }
}

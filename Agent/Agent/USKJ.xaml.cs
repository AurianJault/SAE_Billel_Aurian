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
    /// Logique d'interaction pour USKJ.xaml
    /// </summary>
    public partial class USKJ : UserControl
    {
        public USKJ()
        {
            InitializeComponent();
        }
        private void AKJ(object sender, RoutedEventArgs e)
        {
            Spell.Content = new KJSpellA();
        }
        private void EKJ(object sender, RoutedEventArgs e)
        {
            Spell.Content = new KJSpellE();
        }
        private void CKJ(object sender, RoutedEventArgs e)
        {
            Spell.Content = new KJSpellC();
        }
        private void XKJ(object sender, RoutedEventArgs e)
        {
            Spell.Content = new KJSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

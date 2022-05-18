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
    /// Logique d'interaction pour USReyna.xaml
    /// </summary>
    public partial class USReyna : UserControl
    {
        public USReyna()
        {
            InitializeComponent();
        }
        private void AReyna(object sender, RoutedEventArgs e)
        {
            ReynaSpell.Content = new ReynaSpellA();
        }
        private void EReyna(object sender, RoutedEventArgs e)
        {
            ReynaSpell.Content = new ReynaSpellE();
        }
        private void CReyna(object sender, RoutedEventArgs e)
        {
            ReynaSpell.Content = new ReynaSpellC();
        }
        private void XReyna(object sender, RoutedEventArgs e)
        {
            ReynaSpell.Content = new ReynaSpellX();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

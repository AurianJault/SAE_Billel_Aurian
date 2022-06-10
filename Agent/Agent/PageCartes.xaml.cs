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
    /// Logique d'interaction pour PageCartes.xaml
    /// </summary>
    public partial class PageCartes : UserControl
    {
        public PageCartes()
        {
            InitializeComponent();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            page.Content = new PagePrincipale();
        }
        private void Ascent(object sender, RoutedEventArgs e)
        {
            page.Content = new Ascent();
        }
    }
}

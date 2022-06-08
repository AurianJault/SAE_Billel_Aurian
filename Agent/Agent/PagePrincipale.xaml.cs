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
    /// Logique d'interaction pour PagePrincipale.xaml
    /// </summary>
    public partial class PagePrincipale : UserControl
    {
        public PagePrincipale()
        {
            InitializeComponent();
        }
        private void Agents(object sender, RoutedEventArgs e)
        {
            page.Content = new UserControl4();
        }
    }
}

using ClassLibrary1;
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
    /// Logique d'interaction pour Ascent.xaml
    /// </summary>
    public partial class Ascent : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;
        private string val;
        public string Val { get { return val; } set { val = value; } }
        public Ascent(string val)
        {
            Val = val;
            InitializeComponent();
            DataContext = Manager.GetCarte(val);
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            page.Content = new PageCartes();
        }
    }
}

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
using System.Windows.Shapes;

namespace Agent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void clickInitiateur(object sender, RoutedEventArgs e)
        {
            Initiateur1.Content = new UserControl1();
        }
        
        private void ClickNeon(object sender, RoutedEventArgs e)
        {
            Neon.Content = new USNeon();
        }
    }

}

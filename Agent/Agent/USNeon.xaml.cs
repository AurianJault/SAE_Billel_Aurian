﻿using System;
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
    /// Logique d'interaction pour USNeon.xaml
    /// </summary>
    public partial class USNeon : UserControl
    {
        public USNeon()
        {
            InitializeComponent();
        }

        private void menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Agent
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; set; } = new Manager();

        public App()
        {
            LeManager.ChargeValorant();
            LeManager.chargeCarte();
        }
    }
}

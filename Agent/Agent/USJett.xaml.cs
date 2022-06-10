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
using ClassLibrary1;


namespace Agent
{
    /// <summary>
    /// Logique d'interaction pour USJett.xaml
    /// </summary>
    public partial class USJett : UserControl
    {
        public Manager Manager => (App.Current as App).LeManager;
        public string val;
        public string Val { get; set; }
        public USJett(string val)
        {
            InitializeComponent();
            Val = val;
            DataContext = Manager.GetValorant(val);
        }
        private void AJett(object sender, RoutedEventArgs e)
        {
            if (Val == "Jett")
            {
                Spell.Content = new JettSpellA();
            }
            if (Val == "Phoenix")
            {
                Spell.Content = new PhoenixSpellA();
            }
            if (Val == "Yoru")
            {
                Spell.Content = new YoruSpellA();
            }
            if (Val == "Neon")
            {
                Spell.Content = new NeonSpellA();
            }
            if ( val == "Raze")
            {
                Spell.Content = new RazeSpellA();
            }
            if (Val == "Reyna")
            {
                Spell.Content = new ReynaSpellA();
            }
            if ( val == "Astra")
            {
                Spell.Content = new AstraSpellA();
            }
            if (Val == "Brimstone")
            {
                Spell.Content = new BrimSpellA();
            }
            if (Val == "Omen")
            {
                Spell.Content = new OmenSpellA();
            }
            if (Val == "Viper")
            {
                Spell.Content=new ViperSpellA();
            }
            if (Val == "Breach")
            {
                Spell.Content = new BreachSpellA();
            }
            if (Val == "Fade")
            {
                Spell.Content = new FadeSpellA();
            }
            if (Val == "KAY/O")
            {
                Spell.Content = new KayoSpellA();
            }
            if (Val == "Skye")
            {
                Spell.Content = new SkySpellA();
            }
            if (Val == "Sova")
            {
                Spell.Content = new SovaSpellA();
            }
            if (Val == "Chamber")
            {
                Spell.Content = new ChamberSpellA();
            }
            if (Val == "Cypher")
            {
                Spell.Content = new CypherSpellA();
            }
            if (Val == "Killjoy")
            {
                Spell.Content = new KJSpellA();
            }
            if (Val == "Sage")
            {
                Spell.Content = new SageSpellA();
            }
        }
        private void EJett(object sender, RoutedEventArgs e)
        {
            if (Val == "Jett")
            {
                Spell.Content = new JettSpellE();
            }
            if (Val == "Phoenix")
            {
                Spell.Content = new PhoenixSpellE();
            }
            if (Val == "Yoru")
            {
                Spell.Content = new YoruSpellE();
            }
            if (Val == "Neon")
            {
                Spell.Content = new NeonSpellE();
            }
            if (val == "Raze")
            {
                Spell.Content = new RazeSpellE();
            }
            if (Val == "Reyna")
            {
                Spell.Content = new ReynaSpellE();
            }
            if (val == "Astra")
            {
                Spell.Content = new AstraSpellE();
            }
            if (Val == "Brimstone")
            {
                Spell.Content = new BrimSpellE();
            }
            if (Val == "Omen")
            {
                Spell.Content = new OmenSpellE();
            }
            if (Val == "Viper")
            {
                Spell.Content = new ViperSpellE();
            }
            if (Val == "Breach")
            {
                Spell.Content = new BreachSpellE();
            }
            if (Val == "Fade")
            {
                Spell.Content = new FadeSpellE();
            }
            if (Val == "KAY/O")
            {
                Spell.Content = new KayoSpellE();
            }
            if (Val == "Skye")
            {
                Spell.Content = new SkySpellE();
            }
            if (Val == "Sova")
            {
                Spell.Content = new SovaSpellE();
            }
            if (Val == "Chamber")
            {
                Spell.Content = new ChamberSpellE();
            }
            if (Val == "Cypher")
            {
                Spell.Content = new CypherSpellE();
            }
            if (Val == "Killjoy")
            {
                Spell.Content = new KJSpellE();
            }
            if (Val == "Sage")
            {
                Spell.Content = new SageSpellE();
            }
        }
        private void CJett(object sender, RoutedEventArgs e)
        {
            if (Val == "Jett")
            {
                Spell.Content = new JettSpellC();
            }
            if (Val == "Phoenix")
            {
                Spell.Content = new PhoenixSpellC();
            }
            if (Val == "Yoru")
            {
                Spell.Content = new YoruSpellC();
            }
            if (Val == "Neon")
            {
                Spell.Content = new NeonSpellC();
            }
            if (val == "Raze")
            {
                Spell.Content = new RazeSpellC();
            }
            if (Val == "Reyna")
            {
                Spell.Content = new ReynaSpellC();
            }
            if (val == "Astra")
            {
                Spell.Content = new AstraSpellC();
            }
            if (Val == "Brimstone")
            {
                Spell.Content = new BrimSpellC();
            }
            if (Val == "Omen")
            {
                Spell.Content = new OmenSpellC();
            }
            if (Val == "Viper")
            {
                Spell.Content = new ViperSpellC();
            }
            if (Val == "Breach")
            {
                Spell.Content = new BreachSpellC();
            }
            if (Val == "Fade")
            {
                Spell.Content = new FadeSpellC();
            }
            if (Val == "KAY/O")
            {
                Spell.Content = new KayoSpellC();
            }
            if (Val == "Skye")
            {
                Spell.Content = new SkySpellC();
            }
            if (Val == "Sova")
            {
                Spell.Content = new SovaSpellC();
            }
            if (Val == "Chamber")
            {
                Spell.Content = new ChamberSpellC();
            }
            if (Val == "Cypher")
            {
                Spell.Content = new CypherSpellC();
            }
            if (Val == "Killjoy")
            {
                Spell.Content = new KJSpellC();
            }
            if (Val == "Sage")
            {
                Spell.Content = new SageSpellC();
            }
        }
        private void XJett(object sender, RoutedEventArgs e)
        {
            if (Val == "Jett")
            {
                Spell.Content = new JettSpellX();
            }
            if (Val == "Phoenix")
            {
                Spell.Content = new PhoenixSpellX();
            }
            if (Val == "Yoru")
            {
                Spell.Content = new YoruSpellX();
            }
            if (Val == "Neon")
            {
                Spell.Content = new NeonSpellX();
            }
            if (val == "Raze")
            {
                Spell.Content = new RazeSpellX();
            }
            if (Val == "Reyna")
            {
                Spell.Content = new ReynaSpellX();
            }
            if (val == "Astra")
            {
                Spell.Content = new AstraSpellX();
            }
            if (Val == "Brimstone")
            {
                Spell.Content = new BrimSpellX();
            }
            if (Val == "Omen")
            {
                Spell.Content = new OmenSpellX();
            }
            if (Val == "Viper")
            {
                Spell.Content = new ViperSpellX();
            }
            if (Val == "Breach")
            {
                Spell.Content = new BreachSpellX();
            }
            if (Val == "Fade")
            {
                Spell.Content = new FadeSpellX();
            }
            if (Val == "KAY/O")
            {
                Spell.Content = new KayoSpellX();
            }
            if (Val == "Skye")
            {
                Spell.Content = new SkySpellX();
            }
            if (Val == "Sova")
            {
                Spell.Content = new SovaSpellX();
            }
            if (Val == "Chamber")
            {
                Spell.Content = new ChamberSpellX();
            }
            if (Val == "Cypher")
            {
                Spell.Content = new CypherSpellX();
            }
            if (Val == "Killjoy")
            {
                Spell.Content = new KJSpellX();
            }
            if (Val == "Sage")
            {
                Spell.Content = new SageSpellX();
            }
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            Duelliste.Content = new UserControl4();
        }
    }
}

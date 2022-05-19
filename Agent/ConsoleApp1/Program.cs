using System;
using System.Collections.Generic;
using Classe;
namespace Console_test
{
    internal class Program
    {
        /*Nom type:
         - Sentinels
         - Initiators
         - Duelist
         - Controllers
        */
        static void Main(string[] args)
        {
            ListeAg l1 = new ListeAg();
            Arme a1 = new Arme("Classic", "Pistolet", "Classique");
            Carte c1 = new Carte("Bind");
            Bundle b1 = new Bundle("Reaver");
            Agent ag1 = new Agent("Jett", "Duelist","Coréenne");
            Agent ag2 = new Agent("Neon", "Duelist", "Philippine");
            Agent ag3 = new Agent("Yoru", "Duelist", "japonais");
            Agent ag4 = new Agent("Phoenix", "Duelist", "Royaume-Uni");
            Agent ag5 = new Agent("Raze", "Duelist", "Brésil");
            Agent ag6 = new Agent("Reyna", "Duelist", "Mexique");
            Agent ag7 = new Agent("Brimstone", "Controllers", "United States	");
            Agent ag8 = new Agent("Viper", "Controllers", "United States");
            Agent ag9 = new Agent("Omen", "Controllers");
            Agent ag10 = new Agent("Astra", "Controllers", "Ghana");
            l1.Ajout(ag1);
            l1.ForEach();
        }
    }
}

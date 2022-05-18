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
            l1.Ajout(ag1);
            l1.ForEach();
        }
    }
}

using System;
using Classe;
namespace Console_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arme a1 = new Arme("Classic", "Pistolet", "Classique");
            Carte c1 = new Carte("Bind");
            Bundle b1 = new Bundle("Reaver");
            Agent ag1 = new Agent("Jett", "Duelliste");
            Console.WriteLine(a1);
        }
    }
}

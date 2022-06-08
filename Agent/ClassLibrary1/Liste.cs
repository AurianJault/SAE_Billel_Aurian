using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class ListeAg
    {
        private readonly List<Valorant> duelist;
        private readonly List<Valorant> controllers;
        private readonly List<Valorant> initiators;
        private readonly List<Valorant> sentinels;

        public ListeAg()
        {
            duelist = new List<Valorant> {};
            controllers = new List<Valorant> {};
            initiators = new List<Valorant> {};
            sentinels = new List<Valorant> {};
        }

        public void ForEach()
        {
            Console.WriteLine("Duelist: ");
            duelist.ForEach(Console.Write);
            Console.WriteLine("\n\n\nControllers: ");
            controllers.ForEach(ag => Console.Write(ag));
            Console.WriteLine("\n\n\nInitiators: ");
            initiators.ForEach(ag => Console.Write(ag));
            Console.WriteLine("\n\n\nSentinels: ");
            sentinels.ForEach(ag => Console.Write(ag));
        }

        public void Ajout(Valorant a)
        {
            if (a.Type == "Duelist") this.duelist.Add(a);
            if (a.Type == "Controllers") this.controllers.Add(a);
            if (a.Type == "Initiators") this.initiators.Add(a);
            if (a.Type == "Sentinels") this.sentinels.Add(a);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class ListeAg
    {
        private readonly List<Agent> duelist;
        private readonly List<Agent> controllers;
        private readonly List<Agent> initiators;
        private readonly List<Agent> sentinels;

        public ListeAg()
        {
            duelist = new List<Agent> {};
            controllers = new List<Agent> {};
            initiators = new List<Agent> {};
            sentinels = new List<Agent> {};
        }

        public void ForEach()
        {
            Console.WriteLine("Duelist: ");
            duelist.ForEach(ag => Console.Write(ag));
            Console.WriteLine("Controllers: ");
            controllers.ForEach(ag => Console.Write(ag));
            Console.WriteLine("Initiators: ");
            initiators.ForEach(ag => Console.Write(ag));
            Console.WriteLine("Sentinels: ");
            sentinels.ForEach(ag => Console.Write(ag));
        }

        public void Ajout(Agent a)
        {
            if (a.Type == "Duelist") this.duelist.Add(a);
            if (a.Type == "Controllers") this.controllers.Add(a);
            if (a.Type == "Initiators") this.initiators.Add(a);
            if (a.Type == "Sentinels") this.sentinels.Add(a);
        }
    }
}
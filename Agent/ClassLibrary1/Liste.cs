using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Liste
    {
        private List<Agent> duelist;
        private List<Agent> controllers;
        private List<Agent> initiators;
        private List<Agent> sentinels;

        public Liste()
        {
            List<Agent> duelist = new List<Agent>();
            List<Agent> controllers = new List<Agent>();
            List<Agent> initiators = new List<Agent>();
            List<Agent> sentinels = new List<Agent>();
        }
        public void Ajout(Agent a)
        {
            if (a.Nom == "duelist") duelist.Add(a);
            if (a.Nom == "controllers") controllers.Add(a);
            if (a.Nom == "initiators") initiators.Add(a);
            if (a.Nom == "sentinels") sentinels.Add(a);
        }
    }
}
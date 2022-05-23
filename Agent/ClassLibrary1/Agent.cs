using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Agent
    {
        private string nom;
        private string type;
        private string nationalite;

        public Agent(string nom, string type, ListeAg l, string nationalite = "Inconnu")
        {
            Nom = nom;
            Type = type;
            Nationalite = nationalite;
            l.Ajout(this);
        }
        public string Type { get; set; }
        public string Nom { get; set; }

        public string Nationalite { get; set; }

        public override string ToString()
        {
            return $"Agent: {Nom}\nCatégorie: {Type}\nNationalite: {Nationalite}";
        }

    }
}

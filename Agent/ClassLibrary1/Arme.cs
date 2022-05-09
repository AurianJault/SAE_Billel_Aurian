using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Arme
    {
        private string type;
        private string nom;
        private string cosmetique;

        public Arme(string type, string nom, string cosmetique)
        {
            Type = type;
            Nom = nom;
            Cosmetique = cosmetique;
        }

        public string Nom { get; set; }
        public string Type { get; set; }
        public string Cosmetique { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\nNom: {Nom}\nCosmétique: {Cosmetique}\n";
        }
    }
}

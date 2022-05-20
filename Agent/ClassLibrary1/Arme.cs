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
       
        public Arme(string type, string nom)
        {
            Type = type;
            Nom = nom;
        }

        public string Nom { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\nNom: {Nom}\n";
        }
    }
}

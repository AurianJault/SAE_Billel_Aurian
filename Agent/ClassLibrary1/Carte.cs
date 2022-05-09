using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Carte
    {
        private string nom;

        public Carte(string nom)
        {
            Nom = nom;
        }
        public string Nom { get; set; }
        public override string ToString()
        {
            return $"Nom: {Nom}\n";
        }
    }
}

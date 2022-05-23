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
        private int prix;
       
        public Arme(string type, string nom,int prix)
        {
            Type = type;
            Nom = nom;
            Prix = prix;
        }
        public int Prix { get { return prix; } set { prix = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Type { get { return type; } set { type = value; } }

        public override string ToString()
        {
            return $"Type: {Type}\nNom: {Nom}\nPrix: {Prix}\n";
        }
    }
}

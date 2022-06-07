using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Arme : IEquatable<Arme>
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

        public bool Equals(Arme other)
        {
            return Nom.Equals(other.Nom) && Type.Equals(other.Type);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals((Arme)obj);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
        public override string ToString()
        {
            return $"Type: {Type}\nNom: {Nom}\nPrix: {Prix}\n";
        }
    }
}

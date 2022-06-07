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
        public bool Equals(Arme other)
        {
            return Nom.Equals(other.Nom);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals((Carte)obj);
        }
    }
}

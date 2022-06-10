using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Carte : IEquatable<Carte>
    {
        private string nom;
        private string image;
        private string ingame;
        private string desc;

        public Carte(string nom,string image,string ingame,string desc)
        {
            Nom = nom;
            Image = image;
            Ingame = ingame;
            Desc = desc;

        }
        public string Desc { get { return desc; } set { desc = value; } }
        public string Ingame { get; set; }
        public string Nom { get; set; }
        public string Image { get { return image; } set { image = value; } }
        public override string ToString()
        {
            return $"Nom: {Nom}\n";
        }
        public bool Equals(Carte other)
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
        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}

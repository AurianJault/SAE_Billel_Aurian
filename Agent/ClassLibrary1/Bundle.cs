using System;
using System.Collections.Generic;

namespace Classe
{
    public class Bundle : IEquatable<Bundle>
    {
        private string nom;
        private List<Arme> armes;

        public Bundle(string nom,List<Arme> liste)
        {
            Nom = nom;
            armes = new List<Arme>();
            armes=liste;
        }
        public string Nom { get; set; }
        public List<Arme> Armes { get { return armes; } }

        public bool Equals(Bundle other)
        {
            return Nom.Equals(other.Nom);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals((Bundle)obj);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }

        public void printer()
        {
            Console.WriteLine($"\nNom: {Nom}");
            Armes.ForEach(obj => Console.WriteLine(obj.Nom));
        }
    }
}

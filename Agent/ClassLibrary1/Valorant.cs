using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Valorant : Agent, IEquatable<Valorant>
    {
        private Ultime ultimate;
        private Signature signature;
        private Capacite capA;
        private Capacite capC;
        private Passif passif;
        private string image;
        private string drapeau;
        private string bio;

        public string Bio { get { return bio; } set { bio = value; } }
        public string Drapeau { get { return drapeau; } set { drapeau = value; } }
        public string Image { get { return image; } set { image = value; } }
        public Ultime Ultimate { get { return ultimate; } set { ultimate = value; } }
        public Signature Signature { get { return signature; } set { signature = value; } }
        public Capacite CapA { get { return capA; } set { capA = value;} }
        public Capacite CapC { get { return capC; } set { capC = value; } }
        public Passif Passif { get { return passif; } set { passif = value; } }

        public Valorant(string nom, string type, ListeAg l, string nationalite, Ultime ulti, Signature signature, Capacite capA, Capacite capC, Passif passif,string image,string drapeau,string bio)
            : base(nom, type, nationalite)
        {
            Ultimate = ulti;
            Signature = signature;
            CapA = capA;
            CapC = capC;
            Passif = passif;
            Image = image;
            Drapeau = drapeau;
            Bio = bio;
            l.Ajout(this);
        }

        public bool Equals(Valorant other)
        {
            return Nom.Equals(other.Nom);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType()!= obj.GetType()) return false;
            return Equals((Valorant)obj);
        }
        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}

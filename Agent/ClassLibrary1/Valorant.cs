using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Valorant : Agent
    {
        private Ultime ultimate;
        private Signature signature;
        private Capacite capA;
        private Capacite capC;
        private Passif passif;

        public Ultime Ultimate { get { return ultimate; } set { ultimate = value; } }
        public Signature Signature { get { return signature; } set { signature = value; } }
        public Capacite CapA { get { return capA; } set { capA = value;} }
        public Capacite CapC { get { return capC; } set { capC = value; } }
        public Passif Passif { get { return passif; } set { passif = value; } }

        public Valorant(string nom, string type, ListeAg l, string nationalite, Ultime ulti, Signature signature, Capacite capA, Capacite capC, Passif pass)
            : base(nom, type, l, nationalite)
        {
            Ultimate = ulti;
            Signature = signature;
            CapA = capA;
            CapC = capC;
            Passif = passif;
        }
        public string ToString()
        {
            return base.ToString() + $"\nCapacité A: {CapA}\nCapacité C: {CapC}";
        }
    }
}

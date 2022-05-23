using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Valorant : Agent
    {
        private string ultimate;
        private string signature;
        private string capA;
        private string capC;

        public Valorant(string nom, string type, ListeAg l, string nationalite)
            : base(nom, type, l, nationalite)
        {

        }
    }
}

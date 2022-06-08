using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Manager
    {
        public bool AjoutValorant(Valorant valor)
        {
            if (valorant.Contains(valor))
            {
                return false;
            }
            valorant.Add(valor);
            return true;
        }
        public bool SuprimeValorant(Valorant valor)
        {
            if (!valorant.Contains(valor))
            {
                return false;
            }
            valorant.Remove(valor);
            return true;
        }

        public Valorant GetValorant(Valorant valor)
        {
            return valorant.SingleOrDefault(r => r.Equals(valor));
        }
        public Valorant GetValorant(string nom)
        {
            return GetValorant(new Valorant(nom, "basic", new ListeAg(), "France", new Ultime(1, "Empty", "Empty"), new Signature(0, 0, 0, "Empty", 0, "Empty", "Empty"), new Capacite(0, 0, 0, "Empty", "Empty"), new Capacite(0, 0, 0, "Empty", "Empty"), new Passif("Empty", "Empty")));
        }
    }
}

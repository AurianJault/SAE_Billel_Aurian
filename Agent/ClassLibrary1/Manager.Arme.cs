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
        public bool AjoutArmes(Arme arm)
        {
            if (armes.Contains(arm))
            {
                return false;
            }
            armes.Add(arm);
            return true;
        }
        public bool SuprimeArmes(Arme arm)
        {
            if (!armes.Contains(arm))
            {
                return false;
            }
            armes.Remove(arm);
            return true;
        }

        public Arme GetArme(Arme arm)
        {
            return armes.SingleOrDefault(q => q.Equals(arm));
        }

        public Arme GetArme(string nom, string type)
        {
            return GetArme(new Arme(type, nom, 0));
        }
    }
}

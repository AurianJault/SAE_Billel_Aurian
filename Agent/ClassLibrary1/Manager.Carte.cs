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
        public bool AjoutCarte(Carte valor)
        {
            if (carte.Contains(valor))
            {
                return false;
            }
            carte.Add(valor);
            return true;
        }
        public bool SuprimeCarte(Carte valor)
        {
            if (!carte.Contains(valor))
            {
                return false;
            }
            carte.Remove(valor);
            return true;
        }

        public Carte GetCarte(Carte valor)
        {
            return carte.SingleOrDefault(r => r.Equals(valor));
        }
        public Carte GetCarte(string nom)
        {
            return GetCarte(new Carte(nom,"Null","Null","Null"));
        }
    }
}

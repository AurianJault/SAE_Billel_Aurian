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
        public bool AjoutCartes(Carte cart)
        {
            if (carte.Contains(cart))
            {
                return false;
            }
            carte.Add(cart);
            return true;
        }
        public bool SuprimeCarte(Carte cart)
        {
            if (!carte.Contains(cart))
            {
                return false;
            }
            carte.Remove(cart);
            return true;
        }

        public Carte GetCarte(Carte cart)
        {
            return carte.SingleOrDefault(q => q.Equals(cart));
        }

        public Carte GetCarte(string nom)
        {
            return GetCarte(new Carte(nom));
        }
    }
}

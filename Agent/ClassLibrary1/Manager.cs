using Classe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Manager
    {
        public IReadOnlyCollection<Valorant> Valorants { get; set; }
        public IReadOnlyCollection<Bundle> Bundles { get; set; }
        public IReadOnlyCollection<Arme> Armes { get; set; }
        public IReadOnlyCollection<Carte> Cartes { get; set; }

        List<Valorant> valorant = new List<Valorant>();
        List<Bundle> bundles = new List<Bundle>();
        List<Arme> armes = new List<Arme>();
        List<Carte> carte = new List<Carte>();

        public Manager()
        {
            Valorants = new ReadOnlyCollection<Valorant>(valorant);
            Bundles = new ReadOnlyCollection<Bundle>(bundles);
            Armes = new ReadOnlyCollection<Arme>(armes);
            Cartes = new ReadOnlyCollection<Carte>(carte);
        }

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





        public bool AjoutBundles(Bundle bund)
        {
            if (bundles.Contains(bund))
            {
                return false;
            }
            bundles.Add(bund);
            return true;
        }
        public bool SuprimeBundles(Bundle bund)
        {
            if (!bundles.Contains(bund))
            {
                return false;
            }
            bundles.Remove(bund);
            return true;
        }

        public Bundle GetBundle(Bundle bund)
        {
            return bundles.SingleOrDefault(q => q.Equals(bund));
        }
        public Bundle GetBundle(string nom)
        {
            return GetBundle(new Bundle(nom, new List<Arme>());
        }



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

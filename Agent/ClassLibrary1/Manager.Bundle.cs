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
            return GetBundle(new Bundle(nom, new List<Arme>()));
        }
    }
}

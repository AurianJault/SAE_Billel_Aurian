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
    }
}

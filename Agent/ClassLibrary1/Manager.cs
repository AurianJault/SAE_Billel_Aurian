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
        public ReadOnlyCollection<Valorant> Valorants { get; set; }
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
        public void ChargeValorant()
        {
            valorant.AddRange(new Valorant[]
            {
                new Valorant("Jett", "Duelist", new ListeAg(), "Coréenne", new Ultime(7, "Jett s’équipe de 7 couteaux de lancer. TIREZ pour lancer un couteau sur une trajectoire droite et précise. Jett récupère tous ses couteaux chaque fois qu’elle tue un adversaire avec l’un d’eux.", "Tempête de Lames","/VideoSpell/Jett/JX.png"), new Signature(0, 1, 0.0, "Jett se propulse dans la direction souhaitée", 2, "Eliminations", "Vent arrière","/VideoSpell/Jett/JE.png"), new Capacite(150, 2, 0.6, "Jett se propulse instantanément dans les airs.", "Courant ascendant","/VideoSpell/Jett/JA.png"), new Capacite(200, 2, 4.5,"Lance une fumigène qui se déclanche au contact d'une surface", "Cloud Burst","/VideoSpell/Jett/JC.png"), new Passif("Drift est une abilité qui permet à Jett de planer lorsque qu'elle saute d'une grande hauteur.", "Drift"),"VideoSpell/Jett/jett.jpg","/VideoSpell/Jett/coree.jpg","Représentante de sa patrie, la Corée du Sud, Jett dispose d'un style de combat basé sur l'agilité et l'esquive, qui lui permet de prendre des risques qu'elle seule peut se permettre de prendre. Elle tourne autour des affrontements et découpe ses ennemis avant même qu'ils ne s'en rendent compte."),
                new Valorant("Phoenix")
            });
        }
    }
}

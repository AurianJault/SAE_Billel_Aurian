using System;
using System.Collections.Generic;

namespace Classe
{
    public class Bundle
    {
        private string nom;
        private List<Arme> armes;

        public Bundle(string nom)
        {
            Nom = nom;
            List<Arme> armes = new List<Arme>();
        }
        public void Ajout(Arme a)
        {
            if (a.Cosmetique != Nom) return;
            armes.Add(a);
        }
        public string Nom { get; set; }
        public override string ToString()
        {
            return $"Nom: {Nom}\n";
        }
    }
}

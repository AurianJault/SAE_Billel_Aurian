using System;
using System.Collections.Generic;

namespace Classe
{
    public class Bundle
    {
        private string nom;
        private List<Arme> armes;

        public Bundle(string nom,List<Arme> liste)
        {
            Nom = nom;
            armes = new List<Arme>();
            armes=liste;
        }
        public string Nom { get; set; }
        public List<Arme> Armes { get { return armes; } }

        public void printer()
        {
            Console.WriteLine($"\nNom: {Nom}");
            Armes.ForEach (obj => Console.WriteLine(obj.Nom)) ;
        }
    }
}

using System;
using System.Collections.Generic;
using Classe;
using ClassLibrary1;
namespace Console_test
{
    internal class Program
    {
        /*Nom Shcedule :
         * Arme : X
         * Agents : X
         * Maps : X
         * Bundle : !!!!!!!!!!!!!
         * 
         * 
         * A faire -> 
         *  - Faire le lien entre XAML et c#
         *  - Prévoir des fonctione de get / set
        */
        static void Main(string[] args)
        {
            /*Armes*/
            ListeAg l1 = new ListeAg();
            Arme classic = new Arme("Classic", "Pistolet",0);
            Arme frenzy = new Arme("Frenzy", "Pistolet",450);
            Arme sheriff = new Arme("Sheriff", "Pistolet",800);
            Arme shorty = new Arme("Shorty", "Pistolet",150);
            Arme ghost = new Arme("Ghost", "Pistolet",500);
            Arme stinger = new Arme("Stinger", "Smg",950);
            Arme spectre = new Arme("Spectre", "Smg",1600);
            Arme bucky = new Arme("Bucky", "Shotgun",850);
            Arme judge = new Arme("Judge", "Shotgun",1850);
            Arme bulldog = new Arme("Bulldog", "Rifles",2050);
            Arme guardian = new Arme("Guardian", "Rifles",2250);
            Arme phantom = new Arme("Phantom", "Rifles",2900);
            Arme vandal = new Arme("Vandal", "Rifles",2900);
            Arme marshal = new Arme("Marshal", "Sniper",950);
            Arme operatore = new Arme("Operator", "Sniper",4700);
            Arme ares = new Arme("Ares", "Machine Gun",1600);
            Arme odin = new Arme("Odin", "Machine Gun", 3200);
            Arme knife = new Arme("Knife", "Melee",0);
            /*Liste pour bundle*/
            List<Arme> Reaver = new List<Arme>(){ knife, operatore, vandal, guardian, sheriff};
            List<Arme> Prime = new List<Arme>(){ classic, spectre, guardian, vandal, knife };
            List<Arme> Elderflame = new List<Arme>(){frenzy, judge, vandal, operatore, knife };
            List<Arme> RGX_11z_Pro = new List<Arme>(){ classic, spectre, phantom, operatore, knife };
            List<Arme> Gaia = new List<Arme>(){ghost,marshal,vandal,guardian,knife };
            List<Arme> Undercity = new List<Arme>(){knife,phantom,bulldog,classic,judge};
            List<Arme> Tigris = new List<Arme>(){knife,phantom,spectre,shorty,operatore};
            List<Arme> Protocol = new List<Arme>(){knife,phantom,spectre,sheriff,bulldog};
            List<Arme> Magepunk = new List<Arme>(){knife,ares,operatore,sheriff};
            List<Arme> Spectrum = new List<Arme>(){knife,phantom,guardian,bulldog,classic};
            List<Arme> Recon = new List<Arme>(){knife,ghost,spectre,guardian,phantom};
            List<Arme> Sentinels = new List<Arme>(){knife, sheriff,vandal, operatore, ares};
            List<Arme> Ruination = new List<Arme>(){knife,ghost, spectre, guardian, phantom,};
            List<Arme> Origin = new List<Arme>(){knife,frenzy, bucky, vandal, operatore,};

            /*Carte*/
            Carte c0 = new Carte("Bind");
            Carte c1 = new Carte("Fracture");
            Carte c2 = new Carte("Haven");
            Carte c3 = new Carte("Split");
            Carte c4 = new Carte("Ascent");
            Carte c5 = new Carte("Icebox");
            Carte c6 = new Carte("Breeze");
            /*Bundle*/
            Bundle reaver = new Bundle("Reaver",Reaver);
            Bundle prime = new Bundle("Prime",Prime);
            Bundle gaia = new Bundle("Gaia's Vengeance", Gaia);
            Bundle elderflame = new Bundle("Elderflame",Elderflame);
            Bundle rgx_11z_pro = new Bundle("RGX 11z Pro",RGX_11z_Pro);
            Bundle undercity= new Bundle("Undercity",Undercity);
            Bundle tigris= new Bundle("Tigris",Tigris);
            Bundle protocol= new Bundle("Protocol 781-A", Protocol);
            Bundle magepunk= new Bundle("Magepunk", Magepunk);
            Bundle spectrum= new Bundle("Spectrum", Spectrum);
            Bundle recon = new Bundle("Recon", Recon);
            Bundle sentinels = new Bundle("Sentinels of Light", Sentinels);
            Bundle ruination = new Bundle("Ruination", Ruination);
            Bundle origin = new Bundle("Origin", Origin);
            /*Agent*/
            Agent ag1 = new Agent("Jett", "Duelist", l1, "Coréenne");
            Agent ag2 = new Agent("Neon", "Duelist", l1, "Philippine");
            Agent ag3 = new Agent("Yoru", "Duelist", l1, "japonais");
            Agent ag4 = new Agent("Phoenix", "Duelist", l1, "Royaume-Uni");
            Agent ag5 = new Agent("Raze", "Duelist", l1, "Brésil");
            Agent ag6 = new Agent("Reyna", "Duelist", l1, "Mexique");
            Agent ag7 = new Agent("Brimstone", "Controllers", l1, "United States");
            Agent ag8 = new Agent("Viper", "Controllers", l1, "United States");
            Agent ag9 = new Agent("Omen", "Controllers", l1, "Inconnu");
            Agent ag10 = new Agent("Astra", "Controllers", l1, "Ghana");
            Agent ag11 = new Agent("Sova", "Initiators", l1, "Russia");
            Agent ag12 = new Agent("Breach", "Initiators", l1, "Sweden");
            Agent ag13 = new Agent("Skye", "Initiators", l1, "Australia");
            Agent ag14 = new Agent("KAY/O", "Initiators", l1, "Alternate Timeline Earth");
            Agent ag15 = new Agent("Fade", "Initiators", l1, "Turkey");
            Agent ag16 = new Agent("Killjoy", "Sentinels", l1, "Germany");
            Agent ag17 = new Agent("Cypher", "Sentinels", l1, "Morocco");
            Agent ag18 = new Agent("Sage", "Sentinels", l1, "China");

            /* Passif
             - Description 
            */

            Passif drift = new("Drift est une abilité qui permet à Jett de planer lorsque qu'elle saute d'une grande hauteur.", "Drift");
            Passif terrorTrail = new("Ses capacité vont marqués les ennemis touché et créer une trainée noire, suivant les mouvements de la cible.", "Terror Trail");
            Passif energy = new("Neon possède une barre d'énergie, elle est consommé par sa capacité signature a hauteur de 10% par seconde.","Energy");
            Passif soulHarvest = new("Si un agent ennemi auquel elle a infligé des dégâts au cours des 3 dernières secondes meurt, il déposera un orbe d'âme à son emplacement qui y restera pendant 3 secondes.","Soul Harvest");
            Passif Fuel = new("Viper possède une barre de carburant pour ces deux capacités, elle se consomme à hauteur de 1% toutes les 0,15 secondes pour chacunes des capacités activées", "Fuel");
            Passif passif = new("Passif","Aucun");
            /*Ulti
            - Points
            
             **** Capacite ****
             - Prix
             - Charges
             - Temps

             **** Signature ****
             - restock
             - unit
            */
            /* Jett */

            Capacite averse = new(200, 2, 4.5,"Lance une fumigène qui se déclanche au contact d'une surface", "Cloud Burst");
            Capacite courantAscendant = new(150, 2, 0.6, "Jett se propulse instantanément dans les airs.", "Courant ascendant");
            Signature ventArriere = new(0, 1, 0.0, "Jett se propulse dans la direction souhaitée", 2, "Eliminations", "Vent arrière");
            Ultime tempêteDeLames = new(7, "Jett s’équipe de 7 couteaux de lancer. TIREZ pour lancer un couteau sur une trajectoire droite et précise. Jett récupère tous ses couteaux chaque fois qu’elle tue un adversaire avec l’un d’eux.", "Tempête de Lames");

            Valorant Jett = new Valorant("Jett", "Duelist", l1, "Coréenne", tempêteDeLames, ventArriere, courantAscendant, averse, drift);


            Console.WriteLine(Jett);
        }
    }
}

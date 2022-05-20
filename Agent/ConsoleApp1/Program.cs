using System;
using System.Collections.Generic;
using Classe;
namespace Console_test
{
    internal class Program
    {
        /*Nom bundle:
         - Prime
         - Reaver
         - Elderflame
         - RGX 11z Pro
        */
        static void Main(string[] args)
        {
            ListeAg l1 = new ListeAg();
            Arme a1 = new Arme("Classic", "Pistolet");
            Arme a2 = new Arme("Frenzy", "Pistolet");
            Arme a3 = new Arme("Sheriff", "Pistolet");
            Arme a4 = new Arme("Shorty", "Pistolet");
            Arme a5 = new Arme("Ghost", "Pistolet");
            Arme a6 = new Arme("Stinger", "Smg");
            Arme a7 = new Arme("Spectre", "Smg");
            Arme a8 = new Arme("Bucky", "Shotgun");
            Arme a9 = new Arme("Judge", "Shotgun");
            Arme a10 = new Arme("Bulldog", "Rifles");
            Arme a11 = new Arme("Guardian", "Rifles");
            Arme a12 = new Arme("Phantom", "Rifles");
            Arme a13 = new Arme("Vandal", "Rifles");
            Arme a14 = new Arme("Marshal", "Sniper");
            Arme a15 = new Arme("Operator", "Sniper");
            Arme a16 = new Arme("Ares", "Machine Gun");
            Arme a17 = new Arme("Odin", "Machine Gun");
            Arme a18 = new Arme("Knife", "Melee");
            List<Arme> Reaver = new List<Arme>(){a18, a15, a13, a11, a3};
            List<Arme> Prime = new List<Arme>(){a1, a7, a11, a13,a18 };
            List<Arme> Elderflame = new List<Arme>(){a2, a9, a13,a15,a18 };
            List<Arme> RGX_11z_Pro = new List<Arme>(){a1, a7, a12, a15,a18 };
            Carte c1 = new Carte("Bind");
            Carte c2 = new Carte("Haven");
            Carte c3 = new Carte("Split");
            Carte c4 = new Carte("Ascent");
            Carte c5 = new Carte("Icebox");
            Bundle reaver = new Bundle("Reaver",Reaver);
            Bundle prime = new Bundle("Prime",Prime);
            Bundle elderflame = new Bundle("Elderflame",Elderflame);
            Bundle rgx_11z_pro = new Bundle("RGX 11z Pro",RGX_11z_Pro);
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
            Agent ag181 = new Agent("Sage", "Sentinels", l1, "China");
            reaver.printer();
            rgx_11z_pro.printer();
            elderflame.printer();
            prime.printer();
        }
    }
}

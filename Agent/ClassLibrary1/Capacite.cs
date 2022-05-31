﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Capacite : Passif
    {
        private int prix;
        private int charges;
        private int temps; /* En secondes*/

        public int Prix { get { return prix; } set { prix = value; } }
        public int Charges { get { return charges; } set { charges = value; } }
        public int Temps { get { return temps; } set { temps = value; } }
        public Capacite(int prix, int charges, int temps, string desc,string name):base(desc,name)
        {
            Prix = prix;
            Charges = charges;
            Temps = temps;
        }

        public override string ToString()
        {
            return $"\n{Name}\nPrix: {Prix}\nCharges: {Charges}\nDurée: {Temps}";
        }
    }
    internal class Signature : Capacite
    {
        private int restock;
        private string unit;
        public int Restock { get { return restock; } set { restock = value; } }
        public string Unit { get { return unit; } set { unit = value; } }

        public Signature(int prix, int charges, int temps, string desc, string unit,string name) : base(prix, charges, temps, desc,name)
        {
            Restock = restock;
            Unit = unit;
        }

        public override string ToString()
        {
            return base.ToString()+$"\nSe recharge {Restock}/{Unit}";
        }
    }
}
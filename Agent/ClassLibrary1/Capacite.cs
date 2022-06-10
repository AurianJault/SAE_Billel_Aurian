using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Capacite : Passif
    {
        private int prix;
        private int charges;
        private double temps; /* En secondes*/
        private string image;

        public string Image { get { return image; } set { image = value; } }
        public int Prix { get { return prix; } set { prix = value; } }
        public int Charges { get { return charges; } set { charges = value; } }
        public double Temps { get { return temps; } set { temps = value; } }
        public Capacite(int prix, int charges, double temps, string desc,string name,string image):base(desc,name)
        {
            Prix = prix;
            Charges = charges;
            Temps = temps;
            Image = image;
        }

        public override string ToString()
        {
            return $"\nPrix: {Prix}\nCharges: {Charges}\nDurée: {Temps}\n"+base.ToString();
        }
    }
    public class Signature : Capacite
    {
        private int restock;
        private string unit;
        public int Restock { get { return restock; } set { restock = value; } }
        public string Unit { get { return unit; } set { unit = value; } }

        public Signature(int prix, int charges, double temps, string desc,int restock, string unit,string name,string image) : base(prix, charges, temps, desc,name,image)
        {
            Restock = restock;
            Unit = unit;
        }

        public override string ToString()
        {
            return base.ToString()+$"\nSe recharge au bout de {Restock} {Unit}\n----";
        }
    }
}

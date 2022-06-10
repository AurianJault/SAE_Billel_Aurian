using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Passif
    {
        private string desc;
        private string name;

        public string Desc { get { return desc; } set { desc = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Passif(string desc,string name)
        {
            Desc = desc;
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}:\n{Desc}\n----";
        }
    }
    public class Ultime: Passif
    {
        private int charges;
        private string image;
        public string Image { get { return image; } set { image = value; } }
        public int Charges { get { return charges; } set { charges = value; }}

        public Ultime(int charges, string desc, string name,string image) : base(desc, name)
        {
            Charges = charges;
            Image = image;
        }

        public override string ToString()
        {
            return $"\nUltime :\n{Name}:\nCharges: {Charges}\n----\n{Desc}\n----";
        }
    }
}

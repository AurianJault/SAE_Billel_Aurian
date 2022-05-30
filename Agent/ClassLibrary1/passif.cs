﻿using System;
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
        public string Tostring()
        {
            return $"\n{Name}:\n{Desc}";
        }
    }
    public class Ultime: Passif
    {
        private int charges;
        public int Charges { get { return charges; } set { charges = value; }}

        public Ultime(int charges, string desc, string name) : base(desc, name)
        {
            Charges = charges;
        }

        public string toString()
        {
            return $"\nUltime :\n{Name}:\nCharges: {Charges}\n---\n{Desc}";
        }
    }
}

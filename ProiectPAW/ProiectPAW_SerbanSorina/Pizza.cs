using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_SerbanSorina
{
    public class Pizza: IComparable
    {
        public string denumire;
        public string tip;

        public Pizza(string d, string t)
        {
            denumire = d;
            tip = t;
        }

        public int CompareTo(object obj)
        {
            Pizza p = (Pizza)obj;
            return string.Compare(this.denumire, p.denumire);
        }

        public override string ToString()
        {
            return "Pizza " + denumire + " este de tipul " + tip + ".";
        }
    }
}

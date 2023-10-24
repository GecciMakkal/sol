using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol
{
    internal class Bolygok
    {
        public string nev { get; set; }
        public int holdakSzama { get; set; }
        public double arany { get; set; }

        public Bolygok(string sor)
        {
            string[] s = sor.Split(';');
            nev = s[0];
            holdakSzama = int.Parse(s[1]);
            arany = double.Parse(s[2]);
        }
    }
}

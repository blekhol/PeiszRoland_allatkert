using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
    class Allatkert
    {
        static Random rnd = new Random();
        private List<Allat> allatok;
        private string nev;

        public Allatkert(string nev)
        {
            this.nev = nev;
            allatok = [];
        }

        public List<Allat> Allatok { get => allatok; set => allatok = value; }
        public string Nev { get => nev; set => nev = value; }

        public void Feltoltes()
        {
            for (int j = 0; j < rnd.Next(1, 6); j++)
            {
                allatok.Add(new Viz(rnd.Next(1, 6), "Orka" + (j + 1), "sós", "Antarktisz körül", false));
            }

            for (int j = 0; j < rnd.Next(1, 6); j++)
            {
                allatok.Add(new Hideg(rnd.Next(1, 6), "Pingvin" + (j + 1), "Déli-sark", "fekete-fehér", false));
            }

            for (int j = 0; j < rnd.Next(1, 6); j++)
            {
                allatok.Add(new Mediterran(rnd.Next(1, 6), "Kanári" + (j + 1), "Kanári-szigetek", false, "sárga")); 
            }

            for (int j = 0; j < rnd.Next(1, 6); j++)
            {
                allatok.Add(new Meleg(rnd.Next(1, 6), "Csimpánz" + (j + 1), true, true, "Kongói demokratikus köztársaság"));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
    internal class Meleg : Allat
    {
        private bool melegevan;
        private bool tarsasallat;
        private string legelterjedtebborszag;

        public Meleg(int sebesseg, string nev, bool melegevan, bool tarsasallat, string legelterjedtebborszag)
        {
            this.melegevan = melegevan;
            this.tarsasallat = tarsasallat;
            this.legelterjedtebborszag = legelterjedtebborszag;
            this.sebesseg = sebesseg;
            this.nev = nev;
        }

        public bool Melegevan { get => melegevan; set => melegevan = value; }
        public bool Tarsasallat { get => tarsasallat; set => tarsasallat = value; }
        public string Legelterjedtebborszag { get => legelterjedtebborszag; set => legelterjedtebborszag = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Nev { get => nev; set => nev = value; }
    }
}

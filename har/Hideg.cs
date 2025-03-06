using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
    internal class Hideg : Allat
    {
        private string legelterjedtebborszag;
        private string szin;
        private bool fazik;

        public Hideg(int sebesseg, string nev, string legelterjedtebborszag, string szin, bool fazik)
        {
            this.legelterjedtebborszag = legelterjedtebborszag;
            this.szin = szin;
            this.fazik = fazik;
            this.sebesseg = sebesseg;
            this.nev = nev;
        }

        public string Legelterjedtebborszag { get => legelterjedtebborszag; set => legelterjedtebborszag = value; }
        public string Szin { get => szin; set => szin = value; }
        public bool Fazik { get => fazik; set => fazik = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Nev { get => nev; set => nev = value; }
    }
}

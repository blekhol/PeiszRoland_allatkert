using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
    internal class Mediterran : Allat
    {
        private string legelterjedtebborszag;
        private bool haszonallat;
        private string szin;

        public Mediterran(int sebesseg, string nev, string legelterjedtebborszag, bool haszonallat, string szin)
        {
            this.legelterjedtebborszag = legelterjedtebborszag;
            this.haszonallat = haszonallat;
            this.szin = szin;
            this.nev = nev;
            this.sebesseg = sebesseg;
        }

        public string Legelterjedtebborszag { get => legelterjedtebborszag; set => legelterjedtebborszag = value; }
        public bool Haszonallat { get => haszonallat; set => haszonallat = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Nev { get => nev; set => nev = value; }
    }
}

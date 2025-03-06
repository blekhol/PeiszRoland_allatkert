using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har
{
    internal class Viz : Allat
    {
        private string vizfele;
        private string elohely;
        private bool halfele;

        public Viz( int sebesseg, string nev, string vizfele, string elohely, bool halfele)
        {
            this.vizfele = vizfele;
            this.elohely = elohely;
            this.halfele = halfele;
            this.sebesseg = sebesseg;
            this.nev = nev;
        }

        public string Vizfele { get => vizfele; set => vizfele = value; }
        public string Elohely { get => elohely; set => elohely = value; }
        public bool Halfele { get => halfele; set => halfele = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Nev { get => nev; set => nev = value; }

        public void Usz()
        {
            Console.WriteLine("Úszik");
        }
    }
}

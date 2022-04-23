using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Interfeszek
{
    class Kutya : IEladhato, IKolcsonozheto, IComparable
    {
        static Random r;

        static Kutya()
        {
            r = new Random();
        }

        public string Nev { get; }

        public string Fajta { get; }

        private int ar;

        public int Ar
        {
            get
            {
                return ar;
            }
        }

        public Kutya(string nev, string fajta)
        {
            this.Nev = nev;
            this.Fajta = fajta;
            ar = Nev.Length * Fajta.Length;
        }

        public void LeAkcioz()
        {
            ar -= r.Next(0, ar);
        }

        public int KolcsonzesiAr()
        {
            return ar / 5;
        }

        public int CompareTo(object obj)
        {
            Kutya a = this;
            Kutya b = obj as Kutya;

            return a.Ar.CompareTo(b.Ar);
        }
    }
}

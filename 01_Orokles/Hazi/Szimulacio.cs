using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Szimulacio : TerkepEsJarmuRajzolo
    {
        public Szimulacio(Terkep terkep, int maxJarmuvek) : base(terkep, maxJarmuvek)
        {

        }

        private void EgyIdoEgysegEltelt()
        {
            foreach (var jarmu in jarmuvek)
            {
                if (jarmu is MozgoJarmu) (jarmu as MozgoJarmu).Mozog();
            }
        }

        public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                Kirajzol();
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class TerkepEsJarmuRajzolo : TerkepRajzolo
    {
        protected Jarmu[] jarmuvek;
        protected int jarmuvekN;

        public TerkepEsJarmuRajzolo(Terkep terkep, int maxJarmuvek) : base(terkep)
        {
            jarmuvek = new Jarmu[maxJarmuvek];
            jarmuvekN = -1;
        }

        public void JarmuFelvetel(Jarmu j)
        {
            if (jarmuvekN >= jarmuvek.Length) return;
            jarmuvekN++;
            jarmuvek[jarmuvekN] = j;
            
        }

        protected override char MiVanItt(int x, int y)
        {
            if (jarmuvekN < 0) return ' ';

            for (int i = 0; i <= jarmuvekN;i++)
            {
                if (jarmuvek[i].X == x && jarmuvek[i].Y == y)
                {
                    return jarmuvek[i].Azonosito;
                }
            }

            return ' ';
        }
    }
}

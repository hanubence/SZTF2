using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Jarmu
    {
        char azonosito;
        protected float x, y;
        protected Terkep terkep;

        public Jarmu(char az, float x, float y, Terkep t)
        {
            azonosito = az;
            this.x = x;
            this.y = y;
            terkep = t;
        }

        public char Azonosito
        {
            get { return azonosito; }
        }

        public float X
        {
            get { return x; }
        }

        public float Y
        {
            get { return y; }
        }

        public virtual bool IdeLephet(float x, float y)
        {
            return terkep.TerkepenBeluliPozicio(x, y);
        }
    }

    abstract class MozgoJarmu : Jarmu
    {
        protected float iranyX, iranyY;
        
        public MozgoJarmu(char az, float x, float y, Terkep t) : base(az, x, y, t)
        {

        }

        public void UjIranyVektor(float x, float y )
        {
            iranyX = x;
            iranyY = y;
        }

        public abstract void Mozog();

    }

    class Helikopter : MozgoJarmu
    {
        float sebesseg = 1;


        public Helikopter(float x, float y, Terkep t) : base('H', x, y, t)
        {
            UjIranyVektor(0, 0);
        }

        public void Gyorsit()
        {
            sebesseg += (float)0.1;
        }

        public void Lassit()
        {
            sebesseg -= (float)0.1;
        }

        override public void Mozog()
        {
            if (IdeLephet(X + sebesseg*iranyX, Y + sebesseg*iranyY))
            {
                x += sebesseg * iranyX;
                y += sebesseg * iranyY;
            }
        }
    }

    class Auto : MozgoJarmu
    {
        protected float sebesseg = 2;

        public Auto(float x, float y, Terkep t) : base('A', x, y, t)
        {
            UjIranyVektor(0, 0);
        }

        public override bool IdeLephet(float x, float y)
        {
            return (terkep.TerkepenBeluliPozicio(x, y) && terkep.Magassag(x, y) > 0);
        }

        public override void Mozog()
        {
            if (terkep.Magassag(x, y) > terkep.Magassag(x + iranyX, y + iranyY))
            {
                sebesseg = 3;
            }
            else if (terkep.Magassag(x, y) < terkep.Magassag(x + iranyX, y + iranyY))
            {
                sebesseg = 1;
            } else
            {
                sebesseg = 2;
            }
            
            float ujX = x + sebesseg * iranyX;
            float ujY = y + sebesseg * iranyY;

            if (IdeLephet(ujX, ujY))
            {
                x = x + sebesseg * iranyX;
                y = y + sebesseg * iranyY;
            }
        }
    }

    sealed class Tank : Auto
    {
        int uzemanyag;

        public Tank(float x, float y, Terkep t, int uzem) : base(x, y, t)
        {
            uzemanyag = uzem;
            UjIranyVektor(0, 0);
        }

        public override bool IdeLephet(float x, float y)
        {
            return true;
        }

        public override void Mozog()
        {
            if (uzemanyag > 10)
            {
                x += sebesseg * iranyX;
                y += sebesseg * iranyY;
                uzemanyag -= 10;
            }
        }
    }
}

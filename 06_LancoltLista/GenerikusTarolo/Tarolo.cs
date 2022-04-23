using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusTarolo
{
    class Tarolo<T>
    {
        T[] tomb;

        public Tarolo()
        {
            tomb = new T[0];
        }

        public void Hozzaadas(T elem)
        {
            T[] ujtomb = new T[tomb.Length + 1];
            for (int i = 0; i < tomb.Length; i++)
            {
                ujtomb[i] = tomb[i];
            }
            ujtomb[ujtomb.Length - 1] = elem;
            tomb = ujtomb;
        }
    }
}

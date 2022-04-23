using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Graf
{
    abstract class Graf<T>
    {
        public delegate void BejaroHandler(T tartalom);
        protected class El
        {
            public T hova;
            public double suly;
        }
        public abstract void UjCsucs(T tartalom);

        public abstract void UjEl(T honnan, T hova, double suly = 1, bool iranyitott = false);

        protected abstract List<El> Szomszedok(T csucs);

        public void SzelessegiBejaras(T honnan, BejaroHandler _metodus)
        {
            BejaroHandler metodus = _metodus;
            Queue<T> S = new Queue<T>();
            List<T> F = new List<T>();

            S.Enqueue(honnan);
            F.Add(honnan);

            while (S.Count != 0)
            {
                T k = S.Dequeue();
                metodus?.Invoke(k);
                foreach (El x in Szomszedok(k))
                {
                    if (!F.Contains(x.hova))
                    {
                        S.Enqueue(x.hova);
                        F.Add(x.hova);
                    }
                }
            }
        }

    }
}

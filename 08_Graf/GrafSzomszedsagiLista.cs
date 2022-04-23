using System.Collections.Generic;

namespace SZTF2_Graf
{
    class GrafSzomszedsagiLista<T> : Graf<T>
    {
        List<T> tartalmak;
        List<List<El>> szomszedok;

        public GrafSzomszedsagiLista()
        {
            tartalmak = new List<T>();
            szomszedok = new List<List<El>>();
        }
        public override void UjCsucs(T tartalom)
        {
            tartalmak.Add(tartalom);
            szomszedok.Add(new List<El>());
        }

        public override void UjEl(T honnan, T hova, double suly = 1, bool iranyitott = false)
        {
            int index = tartalmak.IndexOf(honnan);
            szomszedok[index].Add(new Graf<T>.El()
            {
                hova = hova,
                suly = suly
            });

            if (!iranyitott)
            {
                index = tartalmak.IndexOf(hova);
                szomszedok[index].Add(new Graf<T>.El()
                {
                    hova = honnan,
                    suly = suly
                });
            }
        }

        protected override List<El> Szomszedok(T csucs)
        {
            int index = tartalmak.IndexOf(csucs);
            return szomszedok[index];
        }
    }
}

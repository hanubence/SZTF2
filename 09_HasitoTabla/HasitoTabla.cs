using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasitoTabla
{
    class HasitoTabla<K,T>
    {
        class HasitoElem
        {
            public K kulcs;
            public T tartalom;
        }

        public delegate int HasitoDelegalt(K kulcs);
        private HasitoDelegalt hasitofuggveny;

        List<HasitoElem>[] tartalmak;

        private int Mod13(K kulcs)
        {
            return Math.Abs(kulcs.GetHashCode()) % 13;
        }

        public HasitoTabla(HasitoDelegalt hasitofv = null, int tombmeret = 13)
        {
            tartalmak = new List<HasitoElem>[tombmeret];
            for (int i = 0; i < tartalmak.Length; i++)
            {
                tartalmak[i] = new List<HasitoElem>();
            }

            if(hasitofv != null)
            {
                hasitofuggveny = hasitofv;
            }
            else
            {
                hasitofuggveny = Mod13;
            }

        }

        public T this[K kulcs]
        {
            get
            {
                return Kereses(kulcs);
            }
            set
            {
                Beszuras(kulcs, value);
            }
        }

        public void Beszuras(K kulcs, T tartalom)
        {
            int index = hasitofuggveny(kulcs);
            HasitoElem e = new HasitoElem();
            e.kulcs = kulcs;
            e.tartalom = tartalom;
            tartalmak[index].Add(e);
        }

        public T Kereses(K kulcs)
        {
            int index = hasitofuggveny(kulcs);
            return LinearisKereses(kulcs, index);
        }

        private T LinearisKereses(K kulcs, int index)
        {
            int i = 0;
            while (i < tartalmak[index].Count && !tartalmak[index][i].kulcs.Equals(kulcs))
            {
                i++;
            }
            if (i < tartalmak[index].Count)
            {
                return tartalmak[index][i].tartalom;
            }
            else
            {
                throw new ArgumentException("Nincs ilyen kulcsú elem!");
            }
        }
    }
}

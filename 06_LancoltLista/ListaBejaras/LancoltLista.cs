using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_List
{
    class ListaElem<T>
    {
        public T Tartalom { get; set; }
        public ListaElem<T> Kovetkezo { get; set; }
    }


    delegate void BejaroHandler<T>(T tartalom);

    class LancoltLista<T> : IEnumerable<T>
    {
        
        private ListaElem<T> fej;

        public void ElemBeszuras(T tartalom)
        {
            ListaElem<T> uj = new ListaElem<T>();
            uj.Tartalom = tartalom;
            uj.Kovetkezo = fej;
            fej = uj;
        }

        public void Bejaras(BejaroHandler<T> metodus)
        {
            BejaroHandler<T> _metodus = metodus;
            ListaElem<T> p = fej;
            while (p != null)
            {
                _metodus?.Invoke(p.Tartalom);
                p = p.Kovetkezo;
            }
        }

        public void Torles(T torlendo)
        {
            ListaElem<T> e = null;
            ListaElem<T> p = fej;


            while (p != null && !p.Tartalom.Equals(torlendo))
            {
                e = p;
                p = p.Kovetkezo;
            }
            if (p != null)
            {
                //törlés, mert megvan
                if (e == null)
                {
                    //első elemet kell törölni
                    fej = p.Kovetkezo;
                }
                else
                {
                    //valahanyadik elemet kell törölni
                    e.Kovetkezo = p.Kovetkezo;
                }
            }
            else
            {
                //kivételt dobunk, mert nincs ilyen elem a listában
                throw new NincsIlyenElemException();
            }

        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ListaBejaro<T>(fej);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListaBejaro<T>(fej);
        }
    }
}

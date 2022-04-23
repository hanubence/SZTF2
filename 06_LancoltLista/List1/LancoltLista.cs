using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_List
{
    class ListaElem
    {
        public string Tartalom { get; set; }
        public ListaElem Kovetkezo { get; set; }
    }


    delegate void BejaroHandler(string tartalom);

    class LancoltLista
    {
        
        private ListaElem fej;

        public void ElemBeszuras(string tartalom)
        {
            ListaElem uj = new ListaElem();
            uj.Tartalom = tartalom;
            uj.Kovetkezo = fej;
            fej = uj;
        }

        public void Bejaras(BejaroHandler metodus)
        {
            BejaroHandler _metodus = metodus;
            ListaElem p = fej;
            while (p != null)
            {
                _metodus?.Invoke(p.Tartalom);
                p = p.Kovetkezo;
            }
        }

        public void Torles(string torlendo)
        {
            ListaElem e = null;
            ListaElem p = fej;


            while (p != null && p.Tartalom != torlendo)
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
    }
}

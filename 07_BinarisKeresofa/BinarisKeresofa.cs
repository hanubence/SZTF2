﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_BST
{
    class BinarisKeresofa<T,K> : IEnumerable<T> where K : IComparable
    {
        public enum BejarasModja
        {
            InOrder, PreOrder, PostOrder
        }
        class FaElem
        {
            public T tartalom;
            public K kulcs;
            public FaElem bal;
            public FaElem jobb;
        }

        private FaElem gyoker;

        private BejarasModja bejaras;
        public BejarasModja Bejaras
        {
            set
            {
                bejaras = value;
            }
        }

        public T Kereses(K kulcs)
        {
            return _Kereses(gyoker, kulcs);
        }

        public void Torles(K kulcs)
        {
            throw new ArgumentException("Ez sajnos még nincs lekódolva!");
        }

        //törlés privát metódusainak a neve mindegy!

        private T _Kereses(FaElem p, K kulcs)
        {
            if (p != null)
            {
                if (p.kulcs.CompareTo(kulcs) < 0)
                {
                    //jobb
                    return _Kereses(p.jobb, kulcs);
                }
                else if (p.kulcs.CompareTo(kulcs) > 0)
                {
                    //bal
                    return _Kereses(p.bal, kulcs);

                }
                else
                {
                    //kulcs egyenlő a miénkkel
                    return p.tartalom;
                }
            }
            else
            {
                throw new ArgumentException("Nincs ilyen elem a fában!");
            }
        }

        private IEnumerable<T> Tartalom
        {
            get
            {
                List<T> tmp = new List<T>();
                switch (bejaras)
                {
                    case BejarasModja.InOrder:
                    default:
                        _InOrderBejaras(tmp, gyoker);
                        break;
                    case BejarasModja.PreOrder:
                        _PreOrderBejaras(tmp, gyoker);
                        break;
                    case BejarasModja.PostOrder:
                        _PostOrderBejaras(tmp, gyoker);
                        break;

                }
                return tmp;
            }
        }

        public void Beszuras(T tartalom, K kulcs)
        {
            _Beszuras(ref gyoker, tartalom, kulcs);
        }

        private void _Beszuras(ref FaElem p, T tartalom, K kulcs)
        {
            if (p == null)
            {
                p = new FaElem();
                p.tartalom = tartalom;
                p.kulcs = kulcs;
            }
            else
            {
                if (p.kulcs.CompareTo(kulcs) < 0)
                {
                    //jobb részfába szúrunk be
                    _Beszuras(ref p.jobb, tartalom, kulcs);
                }
                else if (p.kulcs.CompareTo(kulcs) > 0)
                {
                    //bal részfába szúrunk be
                    _Beszuras(ref p.bal, tartalom, kulcs);
                }
                else
                {
                    throw new ArgumentException("Van már ilyen kulcsú elem a fában!");
                }
            }
        }

        private void _InOrderBejaras(List<T> lista, FaElem p)
        {
            if (p != null)
            {
                _InOrderBejaras(lista, p.bal);
                lista.Add(p.tartalom);
                _InOrderBejaras(lista, p.jobb);
            }
        }

        private void _PreOrderBejaras(List<T> lista, FaElem p)
        {
            if (p != null)
            {
                lista.Add(p.tartalom);
                _PreOrderBejaras(lista, p.bal);
                _PreOrderBejaras(lista, p.jobb);
            }
        }

        private void _PostOrderBejaras(List<T> lista, FaElem p)
        {
            if (p != null)
            {
                _PostOrderBejaras(lista, p.bal);
                _PostOrderBejaras(lista, p.jobb);
                lista.Add(p.tartalom);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Tartalom.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Tartalom.GetEnumerator();
        }
    }
}

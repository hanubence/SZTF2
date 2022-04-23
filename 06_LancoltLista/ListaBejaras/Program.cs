using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_List
{
    class Program
    {
        static void Bejaro(string tartalom)
        {
            Console.WriteLine(tartalom);
        }

        static void Main(string[] args)
        {
            LancoltLista<char> lista = new LancoltLista<char>();
            lista.ElemBeszuras('B');
            lista.ElemBeszuras('E');
            lista.ElemBeszuras('G');
            lista.ElemBeszuras('S');
            lista.ElemBeszuras('P');

            foreach (char item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (char item in lista)
            {
                Console.WriteLine(item);
            }


            //try
            //{
            //    lista.Torles("Kati");
            //}
            //catch (NincsIlyenElemException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //lista.Bejaras(delegate(string elem)
            //{
            //    Console.WriteLine(elem);
            //});



        }
    }
}

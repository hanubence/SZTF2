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
            LancoltLista lista = new LancoltLista();
            lista.ElemBeszuras("Béla");
            lista.ElemBeszuras("Géza");
            lista.ElemBeszuras("Sanyi");
            lista.ElemBeszuras("Emese");
            lista.ElemBeszuras("Réka");

            try
            {
                lista.Torles("Kati");
            }
            catch (NincsIlyenElemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

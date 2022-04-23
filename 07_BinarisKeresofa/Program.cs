using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarisKeresofa<string, int> fa = new BinarisKeresofa<string, int>();
            fa.Beszuras("Emese", 5);
            fa.Beszuras("Géza", 3);
            fa.Beszuras("Jenő", 10);
            fa.Beszuras("Aranka", 9);
            fa.Beszuras("Feri", 2);

            fa.Bejaras = BinarisKeresofa<string, int>.BejarasModja.PostOrder;

            string keresettNev = fa.Kereses(100);
            

            foreach (var item in fa)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

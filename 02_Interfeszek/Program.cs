using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Interfeszek
{
    class Program
    {
        static void Main(string[] args)
        {
            IEladhato[] termekek = new IEladhato[4];
            termekek[0] = new Kutya("buksi", "németjuhász");
            termekek[1] = new Kutya("buksi2", "bernáthegyi");
            termekek[2] = new MobilTelefon("Apple Iphone X", true);
            termekek[3] = new MobilTelefon("Samsung Galaxy S", false);

            foreach (var item in termekek)
            {
                Console.WriteLine(item.Ar);
            }

            Kutya[] kutyak = new Kutya[4];
            kutyak[0] = new Kutya("buksi", "németjuhász");
            kutyak[1] = new Kutya("berni", "bernáthegyi");
            kutyak[2] = new Kutya("morzsi", "palotapincsi");
            kutyak[3] = new Kutya("blöki", "husky");

            Array.Sort(kutyak);

            



        }
    }
}

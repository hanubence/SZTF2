using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasitoTabla
{

    class Program
    {

        static int Mod19(string kulcs)
        {
            return Math.Abs(kulcs.GetHashCode()) % 19;
        }

        static int HasitasKezdobetuvel(string orszagnev)
        {
            return (int)orszagnev.ToUpper()[0] - (int)'A';
        }

        static void Main(string[] args)
        {
            //"HU" <> Magyarország
            //"UK" <> Egyesült királyság
            //"F" <> Franciaország

            //0:A 1:B 2:C

            HasitoTabla<string,string> ht = new HasitoTabla<string,string>(HasitasKezdobetuvel, 26);
            ht.Beszuras("H", "Magyarország");
            ht.Beszuras("C", "Chile");
            ht.Beszuras("N", "Németország");
            ht.Beszuras("NL", "Norvégia");
            ht.Beszuras("HON", "Honduras");
            //ht.Beszuras("F", "Franciaország");
            ht["F"] = "Franciaország";
            ht.Beszuras("SP", "Spanyolország");
            ht.Beszuras("S", "Svédország");

            Console.WriteLine(ht.Kereses("H"));
            //Console.WriteLine(ht.Kereses("C"));
            Console.WriteLine(ht["C"]);
            Console.WriteLine(ht.Kereses("N"));
            Console.WriteLine(ht.Kereses("NL"));
            Console.WriteLine(ht.Kereses("HON"));
            Console.WriteLine(ht.Kereses("F"));
            Console.WriteLine(ht.Kereses("SP"));
            Console.WriteLine(ht.Kereses("S"));








        }
    }
}

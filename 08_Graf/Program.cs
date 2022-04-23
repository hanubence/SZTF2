using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_Graf
{
    class Program
    {

        static void Kiiro(string tartalom)
        {
            Console.WriteLine(tartalom);
        }
        static void Main(string[] args)
        {
            Graf<string> graf = new GrafMatrixxal<string>(10);

            graf.UjCsucs("Miskolc");
            graf.UjCsucs("Szeged");
            graf.UjCsucs("Pécs");
            graf.UjCsucs("Debrecen");
            graf.UjCsucs("Győr");
            graf.UjCsucs("Siófok");
            graf.UjCsucs("Sopron");
            graf.UjCsucs("Budapest");
            graf.UjCsucs("Eger");
            graf.UjCsucs("Szolnok");

            graf.UjEl("Budapest", "Eger", 140);
            graf.UjEl("Eger", "Miskolc", 60);
            graf.UjEl("Miskolc", "Debrecen", 102);
            graf.UjEl("Debrecen", "Szeged", 228);
            graf.UjEl("Szeged", "Pécs", 189);
            graf.UjEl("Pécs", "Sopron", 277);
            graf.UjEl("Győr", "Sopron", 93);
            graf.UjEl("Győr", "Budapest", 121);
            graf.UjEl("Budapest", "Szolnok", 111);
            graf.UjEl("Eger", "Szolnok", 108);
            graf.UjEl("Miskolc", "Szolnok", 153);
            graf.UjEl("Debrecen", "Szolnok", 131);
            graf.UjEl("Szeged", "Szolnok", 119);
            graf.UjEl("Budapest", "Szeged", 175);
            graf.UjEl("Budapest", "Pécs", 209);
            graf.UjEl("Budapest", "Siófok", 104);
            graf.UjEl("Győr", "Siófok", 135);
            graf.UjEl("Siófok", "Sopron", 191);
            graf.UjEl("Pécs", "Siófok", 115);
            graf.UjEl("Siófok", "Szolnok", 232);

            graf.SzelessegiBejaras("Sopron", Kiiro);


            Console.ReadLine();
        }
    }
}

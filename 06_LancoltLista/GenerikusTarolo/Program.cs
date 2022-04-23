using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusTarolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarolo<string> tar = new Tarolo<string>();
            tar.Hozzaadas("Géza");
            tar.Hozzaadas("Béla");
            tar.Hozzaadas("Gábor");
            
        }
    }
}

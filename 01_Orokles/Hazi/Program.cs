using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Terkep terkep = new Terkep(80, 25);
            Console.WindowHeight = 26;
            Console.WindowWidth = 80;
            Jarmu jarmu = new Jarmu('*', 40, 12, terkep);

            Helikopter hel = new Helikopter(20, 10, terkep);
            hel.UjIranyVektor(1, 0);

            Auto auto = new Auto(20, 5, terkep);
            auto.UjIranyVektor(1, 0);

            Tank tank = new Tank(10, 5, terkep, 100);
            tank.UjIranyVektor(1, 1);


            Szimulacio sim = new Szimulacio(terkep, 5);

            sim.JarmuFelvetel(jarmu);
            sim.JarmuFelvetel(auto);
            sim.JarmuFelvetel(hel);
            sim.JarmuFelvetel(tank);
            sim.Fut();
        }

        static void Main(string[] args)
        {
            Teszt1();
            Console.ReadLine();
        }
    }
}

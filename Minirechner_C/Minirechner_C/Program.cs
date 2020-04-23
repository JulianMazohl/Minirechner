using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minirechner_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;
            int Ergebnis = 0;

            Console.WriteLine("Gib deine 1. Zahl ein: ");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib deine 2. Zahl ein: ");
            Zahl2 = Convert.ToInt32(Console.ReadLine());

            Ergebnis = Addition(Zahl1, Zahl2);
            Console.WriteLine("Das Ergebnis ist: " + Ergebnis);
            Console.ReadKey();
        }

        static int Addition(int zahl1, int zahl2)
        {
            int erg = zahl1 + zahl2;
            return erg;
        }
       
    }
}

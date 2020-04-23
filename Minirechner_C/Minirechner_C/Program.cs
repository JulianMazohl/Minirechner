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
            string Operator;

            Console.WriteLine("Gib deine 1. Zahl ein: ");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib deine 2. Zahl ein: ");
            Zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib die Operation ein (Addition, Subtraktion, Multiplikation, Division)....achte auf die Rechtsschreibung!!!");
            Operator = Console.ReadLine();

            if (Operator == "Addition")
            {
            Ergebnis = Addition(Zahl1, Zahl2);
            }

            if (Operator == "Subtraktion")
            {
                Ergebnis = Subtraktion(Zahl1, Zahl2);
            }

            if (Operator == "Multiplikation")
            {
                Ergebnis = Multiplikation(Zahl1, Zahl2);
            }

            if (Operator == "Division")
            {
                Ergebnis = Division(Zahl1, Zahl2);
            }
            Console.WriteLine("Das Ergebnis ist: " + Ergebnis);
            Console.ReadKey();
        }

        static int Addition(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }
        static int Subtraktion(int zahl1,int zahl2)
        {
            int ergebnis = zahl1 - zahl2;
            return ergebnis;
        }
        static int Multiplikation(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 * zahl2;
            return ergebnis;
        }
        static int Division(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 / zahl2;
            return ergebnis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random veletlen = new Random();
            int szam;
            int parosDb = 0;
            int paratlanDb = 0;

            Console.WriteLine("Generált számok:");

            for (int i = 0; i < 20; i++)
            {
                szam = veletlen.Next(1, 101);
                Console.Write($"{szam} ");

                if (szam % 2 == 0)
                {
                    parosDb++;
                } else
                {
                    paratlanDb++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nEredmények:");
            Console.WriteLine($"Páros számok száma: {parosDb}");
            Console.WriteLine($"Páratlan számok száma: {paratlanDb}");

            Console.ReadKey();

    
        }
    }
}

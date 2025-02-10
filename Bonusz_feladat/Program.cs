using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonusz_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random veletlen = new Random();
            int szam;
            int osszeg = 0;
            int osztoDb;

            Console.WriteLine("Generált számok:");
            
            for (int i = 0; i < 5; i++)
            {
                osztoDb = 1;
                szam = veletlen.Next(1, 91);
                Console.Write($"{szam}, ");

                if (szam % 2 == 0)
                {
                    Console.Write("páros, ");
                } else
                {
                    Console.Write("páratlan, ");
                }

                osszeg += szam;

                for (int j = 1; j <= szam / 2; j++)
                {
                    if (szam % j == 0)
                    {
                        osztoDb++;
                    }
                }

                if (osztoDb > 2)
                {
                    Console.Write("nem prímszám");
                } else
                {
                    Console.Write("Prímszám!!!");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Számok összege: {osszeg}");

            Console.ReadKey();

        }
    }
}

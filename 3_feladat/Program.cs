using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nev;
            int kor;

            Console.Write("Kérem a nevet: ");
            nev = Console.ReadLine();

            Console.Write("Kérem az életkort: ");
            kor = int.Parse(Console.ReadLine());

            if (kor >= 18)
            {
                Console.WriteLine($"{nev} nagykorú!");
            } else if (kor >= 0 && kor < 18)
            {
                Console.WriteLine($"{nev} kiskorú");
            } else
            {
                Console.WriteLine("Az életkor nem lehet negatív szám!");
            }

            Console.ReadKey();
        }
    }
}

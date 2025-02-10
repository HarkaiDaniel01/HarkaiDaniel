using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ar;
            int almaDb;
            int osszAr;

            Console.Write("Egy kg alma ára: ");
            ar = int.Parse(Console.ReadLine());

            Console.Write("Hány kg almát veszel: ");
            almaDb = int.Parse(Console.ReadLine());

            if (ar < 0)
            {
                Console.WriteLine("Az alma ára nem lehet negatív!");
            } else if (almaDb < 0)
            {
                Console.WriteLine("A vásárolt almák száma nem lehet negatív!");
            } else
            {
                osszAr = almaDb * ar;
                Console.WriteLine($"{almaDb} db alma ára {osszAr} korona.");
            }
            
            Console.ReadKey();
        }

    }
}

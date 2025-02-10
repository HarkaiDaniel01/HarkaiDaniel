using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int eredmeny;
            int maradek;

            Console.Write("Első szám: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            b = int.Parse(Console.ReadLine());

            if (b != 0)
            {
                eredmeny = a / b;
                maradek = a - (eredmeny * b);

                Console.WriteLine();
                Console.WriteLine($"{a}:{b}={eredmeny}, maradék: {maradek}");
            } else
            {
                Console.WriteLine("0-val nem lehet osztani!");
            }
            
            Console.ReadKey();

        }
    }
}

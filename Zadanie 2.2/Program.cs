using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._2
{
    internal class Program
    {
        /*Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero. */
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj a = ");
            a = Convert.ToInt32(Console.ReadLine()); ;
            if (a > 0)
                Console.WriteLine("Liczba jest większa od zera");
            else if (a < 0)
                Console.WriteLine("Liczba jest mniejsza od zera");
            else
                Console.WriteLine("Liczba jest równa zero");
            Console.ReadKey(false);

        }
    }
}

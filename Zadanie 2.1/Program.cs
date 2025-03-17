using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._1
{
    internal class Program
        /*Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta.*/
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podak liczbę a = ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba jest parzysta");
            else
                Console.WriteLine("Liczba jest nieparzysta");
            Console.ReadKey(false);
        }
    }
}

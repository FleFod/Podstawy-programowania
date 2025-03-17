using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        /* Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb. */
        {
            double a, b, c; ;
            Console.WriteLine("Podaj a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c ");
            c = Convert.ToDouble(Console.ReadLine());

            if
                ((a <= b) && (a <= c))
                Console.WriteLine("liczba a jest najmniejsza");
            else if
                ((b <= a) && (b <= c))
                Console.WriteLine("liczba b jest najmniejsza");
            else
                Console.WriteLine("liczba c jest najmniejsza");

            if
                ((a >= b) && (a >= c))
                Console.WriteLine("liczba a jest największa");
            else if
                ((b >= a) && (b >= c))
                Console.WriteLine("liczba b jest największa");
            else
                Console.WriteLine("Liczba c jest największa");
            Console.ReadKey(false);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        /*Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny czy też nie.*/
        {
            int rok;
            Console.WriteLine("Podaj rok ");
            rok = Convert.ToInt32(Console.ReadLine());
            if
                (rok % 4 == 0)
                Console.WriteLine("Rok {0} jest przystępny", rok);
            else
                Console.WriteLine("Rok {0} nie jest przystępny", rok);
            Console.ReadKey(false);
        }
    }
}

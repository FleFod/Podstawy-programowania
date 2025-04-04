using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pętle_while_4
{
    class Program
    {
        static void Main(string[] args)
        /*Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
posiadający n wierszy i k kolumn. Użyj pętli while.*/
        {
            int n, k, i, j;
            Console.WriteLine("Podaj liczbę wierszy ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn ");
            k = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= n)
            {
                j = 1;
                while (j <= n)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
                i++;
            }
            Console.ReadKey(false);
        }
    }
}

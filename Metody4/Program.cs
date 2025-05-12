using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metody4
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
            /*Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako argument tej funkcji.*/
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i+1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 5 ma {0} cyfrę", ile_cyfr(5));
            Console.WriteLine("Liczba 8745 ma {0} cyfr", ile_cyfr(8745));
            Console.ReadKey(false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody5
{
    internal class Program
    {
        static int czy_pierwsza(int liczba) /*Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.*/

        {
            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % i == 0) return 0; //tu liczba nie jest pierwsza
            return 1; //tu liczba jest pierwsza (trust)
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy 17 jest liczbą pierwszą {0}", czy_pierwsza(17));
            Console.WriteLine("Czy 23746346 jest liczbą pierwszą {0}", czy_pierwsza(23746346));
            Console.ReadKey(false);
        }
        
                
            

        
    }
}

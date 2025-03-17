using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        /* Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tego miesiąca. Użyj instrukcji wyboru switch.*/
        {
            int tier;
            Console.WriteLine("Podaj poziom ");
            tier = Convert.ToInt32(Console.ReadLine());
            switch (tier)
            {
                case 1: Console.WriteLine("Pz I"); break;
                case 2: Console.WriteLine("Pz II"); break;
                case 3: Console.WriteLine("Pz III"); break;
                case 4: Console.WriteLine("Pz IV "); break;
                case 5: Console.WriteLine("Panther"); break;
                case 6: Console.WriteLine("Tiger 1"); break;
                case 7: Console.WriteLine("Pz VII"); break;
                case 8: Console.WriteLine("Maus"); break;
                default: Console.WriteLine("Nic mi nie wiadomo o rzadnych ambasadorach"); break;
            }
            Console.ReadKey(false);
                
        }
    }
}

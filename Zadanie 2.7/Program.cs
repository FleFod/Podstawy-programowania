using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        /*Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej odpowiednik rzymski.*/
        {
            int a;
            Console.WriteLine("Podaj liczbę rzymską od 1 do 3999 ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 3000) { a -= 3000; Console.WriteLine("MMM"); }
            else if (a >= 2000) { a -= 2000; Console.WriteLine("MM"); }
            else if (a >= 1000) { a -= 1000; Console.WriteLine("M"); }

            if (a >= 900) { a -= 900; Console.WriteLine("CM"); }
            else if (a >= 800) { a -= 800; Console.WriteLine("DCCC"); }
            else if (a >= 700) { a -= 700; Console.WriteLine("DCC"); }
            else if (a >= 600) { a -= 600; Console.WriteLine("DC"); }
            else if (a >= 500) { a -= 500; Console.WriteLine("D"); }
            else if (a >= 400) { a -= 400; Console.WriteLine("CD"); }
            else if (a >= 300) { a -= 300; Console.WriteLine("CCC"); }
            else if (a >= 200) { a -= 200; Console.WriteLine("CC"); }
            else if (a >= 100) { a -= 100; Console.WriteLine("C"); }

            if (a >= 90) { a -= 90; Console.WriteLine("XC"); }
            else if (a >= 80) { a -= 80; Console.WriteLine("LXXX"); }
            else if (a >= 70) { a -= 80; Console.WriteLine("LXX"); }
            else if (a >= 60) { a -= 80; Console.WriteLine("LX"); }
            else if (a >= 50) { a -= 80; Console.WriteLine("L"); }
            else if (a >= 40) { a -= 80; Console.WriteLine("XL"); }
            else if (a >= 30) { a -= 80; Console.WriteLine("XXX"); }
            else if (a >= 20) { a -= 80; Console.WriteLine("XX"); }
            else if (a >= 10) { a -= 80; Console.WriteLine("X"); }

            if (a >= 9) { a -= 9; Console.WriteLine("IX"); }
            else if (a >= 8) { a -= 8; Console.WriteLine("VIII"); }
            else if (a >= 7) { a -= 7; Console.WriteLine("VII"); }
            else if (a >= 6) { a -= 6; Console.WriteLine("VI"); }
            else if (a >= 5) { a -= 5; Console.WriteLine("V"); }
            else if (a >= 4) { a -= 4; Console.WriteLine("IV"); }
            else if (a >= 3) { a -= 3; Console.WriteLine("III"); }
            else if (a >= 2) { a -= 2; Console.WriteLine("II"); }
            else if (a >= 1) { a -= 1; Console.WriteLine("I"); }

            Console.ReadKey(false);
            
            
        }
    }
}

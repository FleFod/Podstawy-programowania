﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
            //Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian
        {
            int a;
            Console.WriteLine("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine()); //zmiana do int32, bo a za duże
            Console.WriteLine("a ^ 3 ={0}", a * a * a);
            Console.ReadKey(true);
        }
    }
}

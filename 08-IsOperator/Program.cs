﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 50;
            int s2 = 200;

            // bool donenDeger = degisken is degiskenTipi

            object o1 = s1;
            object o2 = s2;
            Console.WriteLine(o1);

            bool isKontrol1 = o1 is int;
            bool isKontrol2 = o1 is byte;
            bool isKontrol3 = o2 is byte;
            bool isKontrol4 = o2 is int;

            Console.WriteLine(isKontrol1);
            Console.WriteLine(isKontrol2);
            Console.WriteLine(isKontrol3);
            Console.WriteLine(isKontrol4);

            Console.ReadLine(); 
        }
    }
}

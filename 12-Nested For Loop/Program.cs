﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Nested_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }   
            Console.ReadLine();
        }
    }
}

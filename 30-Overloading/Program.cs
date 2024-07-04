using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Overloadda metod adi ayni olacak parametreler farkli olabilir

            Console.WriteLine("hello"); // Console.WriteLIne bir Overload methoddur.
            Console.WriteLine(true);

            topla(15, 5);
            topla(15.5, 5.5);
            topla(25M, 5M);
            topla("aziz", "karaca");

            System.Threading.Thread.Sleep(2000);
        }

        static void topla(int x, int y)
        {
            int toplam = x + y;
            Console.WriteLine(toplam);
        }

        static void topla(double x, double y)
        {
            double toplam = x + y;
            Console.WriteLine(toplam);
        }

        static void topla(decimal x, decimal y)
        {
            decimal toplam = x + y;
            Console.WriteLine(toplam);
        }

        static void topla(string text1, string text2)
        {
            Console.WriteLine(text1 + " " + text2);
        }
    }
}

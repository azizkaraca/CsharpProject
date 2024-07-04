using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_MethodsInMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir onceki konudan return kullanarak devam ettik. method icinde method kullandik

            EkranaYaz(topla(105, 5));
            EkranaYaz(topla(15.5, 5.5));
            EkranaYaz(topla(25M, 5M));
            EkranaYaz(topla("alan", "karaca"));

            System.Threading.Thread.Sleep(2000);
        }

        static void EkranaYaz(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static int topla(int x, int y) // "static void topla(int x, int y)" yerine deger dondurmesi icin int dedik.
                                       // int toplam = x + y; // return olmadan 
                                       // Console.WriteLine(toplam); // return olmadan
        {
            return (x + y);
        }

        static double topla(double x, double y)
        {
            return (x + y);

        }

        static decimal topla(decimal x, decimal y)
        {
            return (x + y);

        }

        static string topla(string text1, string text2)
        {
            return (text1 + " " + text2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Method_Exercises
{
    public class Math
    {
        public decimal toplama (decimal x, decimal y) // addition
        {
            decimal result = x+y; return result;
        }

        public decimal cikartma (decimal x, decimal y) // subtraction
        {
            decimal result = x-y; return result;
        }

        public decimal bolme (decimal x, decimal y) // division
        {
            decimal result = x/y; return result;
        }

        public decimal carpma (decimal x, decimal y) // multiplication
        {
            decimal result = x*y; return result;
        }

        public void menuList()
        {
            Console.Clear();
            Console.WriteLine("****menu****");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Cikartma");
            Console.WriteLine("3 - Bolme");
            Console.WriteLine("4 - Carpma");
            Console.Write("Lutfen islem seciniz: ");
        }

        public void sonucPrint(decimal x, decimal y, decimal z, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}",x,operators,y,z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool userResult = false; // "bool" java'da "boolean" olarak tanimlanir. 
            userResult = true;

            Console.WriteLine(userResult);  

            bool boolValue; // default olarak false dondurur.
            boolValue = true;

            Console.WriteLine(boolValue);

        }
    }
}

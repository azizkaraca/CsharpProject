using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "aziz", "alan", "alina", "biber" }; // foreach works just with arrays
            foreach (string s in name)   // "foreach (string s : name)" in JAVA 
            {
                Console.WriteLine(s);
            }

        }
    }
}

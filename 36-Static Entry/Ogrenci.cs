using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Static_Entry
{
    public class Ogrenci // internal da olabilir
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne ornegi alindiktan sorna calisan method");
            Test2(); // static olmayan bir method static olan bir methodu cagirabilir
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne ornegi ALINMADAN kullanilabilir");
            // static olan bir method static olmayan, nesne orneklemesine ihtiyac olan, bir methodu cagiramaz.
        }

    }
}

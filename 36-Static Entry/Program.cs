using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Static_Entry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static: Nesne ornegi alinmadan (object olusturmadan) ulasabildigimiz bir metod, bir field yada bir class olabilir.

            Ogrenci.Test2(); // ogrenci classindaki Test2 metodu static oldugundan nesne ornegi olusturmadan direct kullanilabilir

            Ogrenci O1; // stack bolgede pointer olustu
            O1 = new Ogrenci(); // nesne ornegini olsturduk 
            O1.Test1(); // ogrenci classindaki Test1 methodu static olmadigindan nesne ornegi olusturulduktan sonra ancak kullanilabilir

        }
    }
}

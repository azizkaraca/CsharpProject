using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Method_Entry
{
    public class Student // public ile classi diger yerlerden de cagirabilmek icin kullaniriz
    {
        public void entryStudent()
        {
            Console.WriteLine("Student Entry");
        }

        /* erisim belirliyicileri (access modifiers) ; 
         * 
         * Public: her yerden ulasilabilinir
         * Private: sadece class icinden ulasilabilinir
         * Protected: kendi bulundugu classtan veya kalitim yolu ile cagirilan diger classlardan ulasilabilinir
         * Internal: ilgili kutuphane icerisinden ulasilabilinir
         * Internal Protected: ilgili kutuphane icerisinden ulasilabilinir veya kalitim yolu ile ulasilabilinir
         * Note: eger hic bir erisim belirleyicisi belirtmezsek .net framework bunu private olarak algilar
         */

        public void StudentMethod(string name, string surname) 
        {
            Console.WriteLine("Student Details: {0} {1}",name,surname);
        }


    }
}

using _24_Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //M1.id = 1;
            //M1.name = "aziz";
            //M1.surname = "karaca";

            /* Field deger atamasi yapilamasin ama deger okunabilsin
             * Field deger atamasi yapilsin ama deger okunamasin
             * Field deger atamasi yapilsin ama degerin ilk 4 hanesi okunsun
             * Field deger atamasi ve okuma islemleri yapilsin ama bu iki islemde bizim belirledigimiz bir surecten gecsin veri daha sonra gosterilsin
             * 
             */

            // Encapsulation giris
            M1.Email = "aziz@karaca.tr";
            Console.WriteLine(M1.Email);

            // Field deger atamasi yapilamasin ama deger okunabilsin
            Console.WriteLine("Musteri ID degeri = " + M1.ID.ToString());
           // M1.ID = 10110; // set kismini kontrollu yapmak icin private yaptigimiz icin bu sekilde bir deger atamasi yapamayiz.


        }
    }
}


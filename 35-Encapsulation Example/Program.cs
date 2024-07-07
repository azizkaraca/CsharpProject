using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Encapsulation_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Ogrenci sinifinin iserisinde ogrenci no adinda bir private field tanimi yapalim
             * ve asagidaki kurallara gore kapsulleme islemlerini yapalim
             * SET
             * 1-girilen deger 4 basamakli olsun
             * 2-girilen deger icerisindeki tum degerler sayilasal deger olmali
             * 
             * GET
             * 1-deger gizli oldugu icin okunamasin
             * 2-degerin ilk 2 basamagini gostersin
             * 
             */


            Student S1 = new Student();

            S1.StudentNumber = "1234";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            topla(23, 5, 14, 56, 3, 87); // asagidaki paramli metod kullanimi
        }
      
        static void topla(params int[] sayilar) // params kullanildiginda istedigimiz kadar parametre gierbiliyoruz.
                                                // JAVAda "public double cevre(int... dizi)" gibi.
     // static void topla(string text, params int[] sayilar) // params en son parametre olmali eger baska parametrelerde kullanilacaksa!
        {
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam = {0}", toplam);
        }
    }
}

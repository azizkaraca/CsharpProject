using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _27_Method_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            YenidenIslemYap: // buraya label koyarak swich case de default islemde goto metodu ile yeniden bu islemleri yaptiririz.

            math.menuList();
            int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. sayiyi giriniz: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("2. sayiyi giriniz: ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1:
                    sonuc = math.toplama(sayi1, sayi2);
                    math.sonucPrint(sayi1, sayi2, sonuc, "+");
                    break;

                case 2:
                    sonuc = math.cikartma(sayi1, sayi2);
                    math.sonucPrint(sayi1, sayi2, sonuc, "-");
                    break;

                case 3:
                    sonuc = math.bolme(sayi1, sayi2);
                    math.sonucPrint(sayi1, sayi2, sonuc, "/");
                    break;

                case 4:
                    sonuc = math.carpma(sayi1, sayi2);
                    math.sonucPrint(sayi1, sayi2, sonuc, "*");
                    break;

                default:
                    Console.WriteLine("girmis oldugunuz islem listede yoktur!");
                    Console.WriteLine("lutfen yeniden deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;

            }

            Console.WriteLine("yeniden islem yapmak istiyormusunuz? E/H");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}

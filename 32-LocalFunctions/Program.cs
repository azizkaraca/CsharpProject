using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionKullanimi(12, 22);

        }

        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            int topla (int gelenSayi1,  int gelenSayi2) // bu metod kullanilan scoplar arasinda kullanilir sadece ve mainden cagirilamaz.
                                                        // Buna local Function yada method kullanimi denir.
            {
                return gelenSayi1 + gelenSayi2;
            }

            int toplamDeger = topla(sayi1,sayi2);
            Console.WriteLine(toplamDeger);
        }
    }
}

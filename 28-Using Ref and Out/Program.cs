using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Using_Ref_and_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no1 = 0;
            degerAta(ref no1); // deger hazfizada yer tutmadan ref bolgede olusturuldu ver deger atamasi yapildi ref bu ise yarar !

        }
        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }
    }
}

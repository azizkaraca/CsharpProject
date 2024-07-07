using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_OOP_Entry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            _02_Arac A1 = new _02_Arac("Tesla", "Model X", 2024, 575);
            A1.alisFiyat = 110000;
            A1.satisFiyat = 120000;
            A1.maxindirim = 2500;
            // A1.fiyat =     // encapsulation konusu
            A1.FiyatAta(115000);
            A1.BilgileriGoruntule();
            #endregion


            _01_Musteri M1 = new _01_Musteri();
            M1.idNo = "1324354657";
            M1.name = "Alan";
            M1.surname = "Karaca";
            M1.sex = 11111;

            _01_Musteri M2 = M1;

            M2.idNo = "1425364745"; // boyle yaparsak M1 deki degeri de degistirmis oluyoruz. M2 ile M1 ayni yeri isaret ettigi icin
            M1.name = "Aziz"; // yine M1 degistirdigimizde M2 degerinide degistirmiz oluyoruz. M1 ile M2 ayni yeri isaret ettigi icin

            bool musteriKOntrol = M1.MusteriKontrol();

            //M2 = null;
            //M1 = null;

            //string name = M2.name; // M2 null yaptigimiz icin sistem hatasi alacagiz
        }
    }
}

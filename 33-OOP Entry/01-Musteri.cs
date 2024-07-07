using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_OOP_Entry
{
    public class _01_Musteri
    {
        // yapici metodlar (constructor)

        public _01_Musteri() // constructor yapma sekli. JAVA ile ayni
        {
            idNo = "222222";
        }

        public _01_Musteri(string _idNo, string _name) // constructur iclerine deger atamasi yaparak overload yapabiliriz. 
        {
            idNo = _idNo;  // burada demek istedigimiz bu deger parantez icerisindeki degere esit. bunun icin burada "this" kelimesini kullanacagiz daha sonra
            name = _name;
        }
        public _01_Musteri(string _idNo, string _name, string _surname)
        {
            idNo = _idNo;
            name = _name;
            surname = _surname;
        }
        public _01_Musteri(string _idNo, string _name, string _surname, int _sex)
        {
            idNo = _idNo;
            name = _name;
            surname = _surname;
            sex = _sex;
        }

        public string idNo; // public belirterek diger claslardan cagirabiliriz. yazmazsak otomatik private olur.
        public string name;
        public string surname;
        public int sex;  // 11111: erkek , 88888 kadin

        public bool MusteriKontrol() 
        {

            bool kontrol = MusteriKontrolDB(idNo);
            return true;
        }

        private bool MusteriKontrolDB(string idNo) // private olunca class icerisinden ulasabiliriz. baska classdan ulasamayiz
        {
            // database e git musteri idNo ya gore daha once boyle bir kayit var mi kontrol et


            return true;
        }

    }
}

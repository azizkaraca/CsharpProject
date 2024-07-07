using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Static_Exersice
{
    internal class Musteri
    {
        #region Sanal DataBase
        static ArrayList musteriDatabase;
        #endregion

        #region Static Constructor
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion

        #region Fields
        public int MusteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        private string sifre { get; set; }
        #endregion

        #region Encapsulation
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);

                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediginiz kullanici adi sistemde kayitilidir.");
                    this._kullaniciAdi = string.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }
        #endregion

        #region Static Methods
        static bool musteriKullaniciAdiKontrol(string kullaniciAdi)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.KullaniciAdi == _kullaniciAdi)
                {
                    Kontrol = true;
                    break;
                }
            }

            return Kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            #region Parametre Kontrol
            if (M != null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediginiz kullanici sistemde kayitli");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayit islemi basarili");
                }
            }
            #endregion
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.emailAdres == _emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }return Kontrol;   
        }
        #endregion
    }
}

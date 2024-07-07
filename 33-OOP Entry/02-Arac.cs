using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _33_OOP_Entry
{
    public class _02_Arac
    {
        // class > fields
        public string marka;
        public string model;
        public int modelYil;
        public decimal km;
        public int yakitTip;
        public int vitesTip;
        public decimal alisFiyat;
        public decimal satisFiyat;
        public decimal maxindirim;
        public decimal fiyat;

        public _02_Arac()
        {

        }

        public _02_Arac(string _marka, string _model)
        {
            marka = _marka;
            model = _model;
        }
        public _02_Arac(string _marka, string _model, int _modelYil)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
        }
        public _02_Arac(string _marka, string _model, int _modelYil, decimal _km)
        {
            marka = _marka;
            model = _model;
            modelYil = _modelYil;
            this.km = _km; // this kullaniminda karsi degere _km demeden km diyebiliriz.
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine(" marka {0} - model {1} - yil {2}", marka, model, modelYil);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = satisFiyat - maxindirim;
            if (_fiyat < fiyatHesap)
            {
                Console.WriteLine("Gecersiz fiyat girisi");
            }
            else
            {
                Console.WriteLine("Fiyat guncellendi");
            }
        }
    }
}


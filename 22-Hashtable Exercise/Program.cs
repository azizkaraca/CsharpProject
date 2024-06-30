using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Hashtable_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sozluk olusturma uygulamasi yapalim
            // Hashtable icinde ENG - TR olarak data ekleyiniz.

            /* Yeni kayit eklemek istiyormusunuz E/H
             * E : yeni kayit ekleme islemi yapilsin
             * H : Tum liste yazdirilsin
             * 
             * Var olan bir key deger ekleniyor ise kullaniciya uyari olarak bu deger daha once "...." seklinde vardir desin/
             * 
             */

            Hashtable h1 = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediginiz sozluk degerini giriniz : ");
                Console.Write("EN : ");
                string eng = Console.ReadLine();

                bool kontrol1 = h1.ContainsKey(eng);
                if (kontrol1)
                {
                    Console.WriteLine("\"{0}\" sozlukte bulunmaktadir. \"{1}\" turkce karsiligidir", eng, h1[eng].ToString());

                }
                else
                {
                    Console.Write("\"ENG: {0}\" turkce karsiligini girin : ",eng);
                    string tur = Console.ReadLine();
                    h1.Add(eng, tur);
                    Console.WriteLine("ekleme islemi basarili");
                }

                Console.Write("yeni deger eklemek istiyormusunuz? E/H : ");

            } while (Console.ReadLine().ToUpper() != "H");

            //1. yontem
            foreach (var item in h1.Keys) // var degeri kullandik
            {
                Console.WriteLine("1 - ENG, {0} = TUR, {1}", item, h1[item]);
            }

            //2.yontem -- > daha iyi bir yazim sekli gibi
            //foreach (var item in h1.Values) donecek degerin tipini bulmak icin once "var" ile donduk
            foreach (DictionaryEntry item in h1)
            {
                //  Console.WriteLine(item.GetType().Name); // donen degerin tipini bulmak icin yaptik. bunula birlikte DictionaryEntry dondugunu gorup foreach ona gore duzenledik
                Console.WriteLine("2 - ENG, {0} = TUR, {1}", item.Key, item.Value);    
            }

            System.Threading.Thread.Sleep(3000);
         
        }
    }
}

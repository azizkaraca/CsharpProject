using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); // C# da, java'da oldugu gibi tipleri vermemize gerek yok
            //HashMap<Integer, Integer> hm = new HashMap<>(); // JAVA da bu sekilde, tipleri vermemiz gerekiyor

            //ht.Add("key", "value"); // key, value bu sekilde eklenir. key degerleri unique olmali, value degerleri ayni olabilir
            ht.Add("car", "auto");
            ht.Add("house", "haus");
            ht.Add(2, "aziz");

            System.Threading.Thread.Sleep(3000); // bekletme islemi sonucu consoldo gorebilmek icin.

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList(); // default olarak capacity 4, (4 e ulasinca 8) count 0 olarak olusturuldu.
            // ArrayList<String> isimler = new ArrayList<>();  // java da bu sekilde arraylist tanimlariz.
            // C# da array liste karisik deger eklenebilir string, int gibi ama JAVA da bu yapilamaz.

            arrayList1.Add(10); // eleman ekleme bu sekilde yapilir.
            arrayList1.Add("aziz"); 

            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("alan");
            arrayList2.Add("alina");
            arrayList2.Add(1020);
            arrayList2.Add(1030);
            arrayList2.Add("tulay");
            arrayList2.Add("nihat");

            arrayList1.AddRange(arrayList2); //arrayList1'e arrayList2'deki elemanlarida ekliyorum

            object o1 = arrayList1[2]; // koleksiyon icindeki bir degere index vererek ulasmak.
            object o2 = arrayList1[4]; // koleksiyon icindeki bir degere index vererek ulasmak.
            string s1 = arrayList1[2].ToString(); // objeyi stringe cevirmek ve string olarak almak icin ToString() metodu kullaniriz
            int i4 = (int) arrayList1[4]; // bu da int'e cevirip almak

            //Console.WriteLine(o1);
            //Console.WriteLine(o2);

            arrayList1[1] = "karaca"; // 1.indexteki degeri bu sekilde degistiriyoruz

            arrayList1.Remove("karaca"); // deger vererek listten silmek
            arrayList1.RemoveAt(0); // index vererek listten silmek
            arrayList1.RemoveRange(2, 2); // index range vererek listten silmek (2.indexten sonraki 2 tane elemani sil) (int leri sildik sonraki Sort() metodu icin)
            arrayList1.Sort(); // arrayList1'deki degerler default olarak buyukten kucuge olarak siralar (icerideki degerler ayni tip olmasi lazim)
            arrayList1.Reverse(); // arrayList1'deki degerleri terse cevirir 

            bool control1 = arrayList1.Contains("alan");
            bool control2 = arrayList1.Contains(1020);

            int indexOf = arrayList1.IndexOf("alan");

            //arrayList1.Clear(); // arrayin icini komple temizler.
            //arrayList1.TrimToSize(); // arrayList1'in capasitesini guncellemek icin (4, e getirdi yada ne kadar kaldiysa ona gore trim eder kendisini)

            object[] array = arrayList1.ToArray(); // arrayList'i diziye cevirir verir

            Console.ReadLine();
        }
    }
}

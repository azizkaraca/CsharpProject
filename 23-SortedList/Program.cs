using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedList key degerine gore kendini A-Z ye siralar, ayni tip olmalidir aksi taktirde hata verir

            SortedList sortedList = new SortedList();
            sortedList.Add(38, "aziz");
            sortedList.Add(32, "alina");
            sortedList.Add(1, "alan");
            sortedList.Add(6, "biber");
            //sortedList.Add("A", "karaca"); // burada int den farkli olarak string bir key girdigimiz icin siralayamaz.

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("{0} age , {1} name",item.Key,item.Value);
            }
            System.Threading.Thread.Sleep(2000);
        }
        
    }
}

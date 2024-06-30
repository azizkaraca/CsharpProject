using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first in first out sistemi uzerine calisir
            // yani ilk gireni ilk olarak isleme alir, eklenme sirasina gore listeye ekler.
            // icindeki tipler farketmez herhangi bir sort islemi yapmadigi icin

            Queue queue = new Queue();
            queue.Enqueue("aziz"); // iceriye ekleme sekli
            queue.Enqueue(38);
            queue.Enqueue("alina");
            queue.Enqueue(32);
            queue.Enqueue("alan");
            queue.Enqueue(1);

            object o1 = queue.Dequeue(); // islenen degeri isleme alir ve listeden cikartir
            object o2 = queue.Peek(); // islenen degeri isleme alir ama listeden cikarmaz sadece belirtir

            foreach (var item in queue)
            {
                Console.WriteLine(item.ToString());
            }

            System.Threading.Thread.Sleep(2000);


        }
    }
}

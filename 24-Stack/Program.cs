using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  last in first out sistemi uzerinde calisir.
            //  yani son girilen degeri ilk siraya ekler ve o sekilde reverse ederek listeye ekler.
            //  icindeki tipler farketmez herhangi bir sort islemi yapmadigi icin

            Stack stack = new Stack();
            stack.Push("aziz"); // iceriye ekleme sekli
            stack.Push(38);
            stack.Push("alina");
            stack.Push(32);
            stack.Push("alan");
            stack.Push(1);

            object o1 = stack.Pop(); // islenen degeri isleme alir ve listeden cikartir
            object o2 = stack.Peek(); // islenen degeri isleme alir ama listeden cikarmaz sadece belirtir

            foreach (var item in stack) 
            {
                Console.WriteLine(item.ToString());
            }

            System.Threading.Thread.Sleep(2000);


        }
    }
}

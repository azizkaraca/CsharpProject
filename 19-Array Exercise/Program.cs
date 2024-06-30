using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Array_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Array Lenght : ");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());

            int[] newArray = new int[arrayLenght];

            for (int elements = 0; elements<newArray.Length; elements++) // kullanicidan eklenecek elemanlari istemek ve diziye eklemek icin
            {
                Console.Write("please enter your {0}. value : ", elements);
                newArray[elements] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("you filled all array elements!");

            foreach (int element in newArray) // eklenen tum elemanlari gormek icin
            {
                Console.WriteLine("all added elements : " + element);
            }

            int sum = 0;
            int avarage = 0;

            foreach (int element in newArray) // elemanlarin toplaminin ortalamasini almak icin
            {
                sum += element;
                avarage = sum/newArray.Length;
            }
            Console.WriteLine("avarage : " + avarage);
            Console.ReadLine();
        }
    }
}

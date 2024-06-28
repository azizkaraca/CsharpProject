using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sistemin olusturdugu random sayiyi tahmin ile bulan bir uygulama yapalim.

            Random random = new Random(); // random sayi olusturmak icin once yeni bir random objesi olusturuyoruz
            int randomNo = random.Next(1,10); // bu method 1 ile 10 arasinda random sayi olusturuyor.
            int count = 1;

            while (true)
            {
                Console.Write("please enter your {0}. try number: ",count);
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == randomNo)
                {
                    Console.WriteLine("Congratulation you have found the number at your {0}. try.",count);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}. try is not correct! Please try again.",count);
                    count++;
                }
                
            }
            Console.ReadLine();

        }
    }
}

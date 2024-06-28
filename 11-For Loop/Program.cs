using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region for loop entry
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + ". number");
            }
            #endregion


            #region write even numbers between 1-100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " even number");
                }

                #endregion


            #region sum even numbers between 1-100
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine("sum of even numbers: " + sum);
            Console.ReadLine();
            #endregion


            }
        }
    }
}

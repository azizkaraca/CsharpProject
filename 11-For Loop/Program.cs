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
            // the usage of for loop same with JAVA 

            #region for loop entry  
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + ". number");
            }
            #endregion
            
            #region write even numbers between 1-100
            for (int count = 1; count <= 100; count++)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count + " even number");
                }
            }
            #endregion
            
            #region sum even numbers between 1-100
            int sum = 0;
            for (int even = 2; even <= 100; even++)
            {
                if (even % 2 == 0)
                {
                    sum += even;
                }
            }
            Console.WriteLine("sum of even numbers: " + sum);
            Console.ReadLine();
            #endregion


            
        }
    }
}


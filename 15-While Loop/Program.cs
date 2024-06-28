using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter a number to reverse: ");
            int orginalNo = Convert.ToInt32(Console.ReadLine());

            int number = orginalNo;
            int reverse = 0;

            while (number != 0)
            {
                reverse = reverse * 10 + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Reverse number of " + orginalNo + " " + "is " + reverse);
            Console.ReadKey();
        }
    }
}

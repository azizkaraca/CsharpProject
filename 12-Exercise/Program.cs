using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Exercise

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number to make pyramid: ");
            string number = Console.ReadLine();
            int no = Convert.ToInt32(number);

            for (int row = 0; row < no; row++)
            {
                for (int blank = 0; blank < no - (row + 1); blank++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < 1 + (row * 2); star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username = string.Empty;
            string password = string.Empty;
            int count = 0;

            do
            {
                if (count > 0) // bunu buraya koymamiz gerekiyordu ki ilk denemeden sonra hata olursa calisacak
                Console.WriteLine("your {0}. try is not correct!",count); 

                Console.Write("Please enter username: ");
                username = Console.ReadLine();

                Console.Write("Please enter password: ");
                password = Console.ReadLine();

                count++;

            } while (username.ToLower() != "demo" || password.ToLower() != "memo");

            Console.WriteLine("Congratulation!");

        }
    }
}

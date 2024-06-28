using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUsername, correctPassword;

            Console.Write("please enter your username: ");
            string username = Console.ReadLine();

            Console.Write("please enter your password: ");
            string password = Console.ReadLine();


            correctUsername = "admin";
            correctPassword = "1234";

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Congratulation You logged in :)");
            }
            else
            {
                Console.WriteLine("Wrong credentials!");
            }
            Console.ReadLine();

        }
    }
}

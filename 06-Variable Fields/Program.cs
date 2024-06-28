using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Variable_Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome!");

            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Please Enter Your Surname: ");
            string surname = Console.ReadLine();

            Console.Clear(); // Bununla ekrana girilen seyleri temizler. temiz bir cikti verir.

            Console.WriteLine("Full Name: " + name + " " + surname);

        }
    }
}

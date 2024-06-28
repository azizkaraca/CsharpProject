using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Time_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now; // Java'da "LocalDateTime today = LocalDateTime.now();" ama formatlanmasi lazim
            Console.WriteLine("Today: " + dateTime);
            Console.ReadLine();

        }
    }
}

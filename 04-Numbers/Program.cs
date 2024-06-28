using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number1 = 10;
            int number2 = 20;
            Console.WriteLine(number1 + number2);

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            decimal decimalMinValue = decimal.MinValue; // deger tanimlanirken sayinin sonuna M koyariz. "10.2M gibi"
            decimal decimalMaxValue = decimal.MaxValue;

            float floatMinValue = float.MinValue; // deger tanimlanirken sayinin sonuna F koyariz. "10.2F gibi"
            float floatMaxValue = float.MaxValue;

            Console.WriteLine(byteMinValue);
            Console.WriteLine(byteMaxValue);

            Console.WriteLine(intMinValue);
            Console.WriteLine(intMaxValue);

            Console.WriteLine(doubleMinValue);
            Console.WriteLine(doubleMaxValue);

            Console.WriteLine(decimalMinValue);
            Console.WriteLine(decimalMaxValue);

            Console.WriteLine(floatMinValue);
            Console.WriteLine(floatMaxValue);


            Console.ReadLine();

        }
    }
}

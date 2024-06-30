using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentList = new string[5]; // array olusturmak icin once kac tane olusturulacaksa onun sayisini veririz. JAVA ile ayni

            studentList[0] = "aziz"; // dizinin icerisine degerleri index ile ekliyoruz. JAVA ile ayni
            studentList[1] = "alina";
            studentList[2] = "alan";
            studentList[3] = "biber";
            studentList[4] = "Karaca";

            foreach (string students in studentList)
            {
                Console.WriteLine("with foreach : " + students); // listenin tumunu yazdirma sekli foreach ile yapilir
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("with for : " + studentList[i]);
            }

            Console.WriteLine("with index : " + studentList[2]); // belirli indexteki elemani yazdirma

            Console.ReadLine();

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

        }
    }
}

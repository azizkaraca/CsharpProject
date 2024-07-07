using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Encapsulation_Example
{
    internal class Student
    {

        private string studentNumber;
        public string StudentNumber
        {
            get { return studentNumber.Substring(0, 2); }
            set
            {
                if (value.Length == 4)
                {
                    bool flag = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool charKontrol = char.IsNumber(value[i]);
                        if (charKontrol)
                        {
                            // char sayisal bir deger
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                        if (flag)
                        {
                            Console.WriteLine("Numara sayisal deger olmalidir");
                        }
                        else
                        {
                            this.studentNumber = value;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numara 4 haneli olmali");
                }
            }
        }

        private int NoCreate()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 2000);
        }

    }
}

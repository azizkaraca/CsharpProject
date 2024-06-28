using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_AsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";
            object obj = text;
            string textResult = obj as string; // obj ici string mi, string ise onu stringe cevir ve textResulta ata
        }
    }
}

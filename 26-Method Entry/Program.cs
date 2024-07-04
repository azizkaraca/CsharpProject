using System; // bir kutuphane dasyasini uygulama icerisine eklenmektir
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Method_Entry // yeni bir kutuphane yapmak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aziz"); // using System kutuphanesinin Console clasindan WriteLine methodunu cagiriyoruz.
            Entry(); // asagidaki methodu cagirdik

            Student S1 = new Student(); // diger clasta olusturdugumuz methodu kullanmak icin o classi bu main de nesne olusturarak
                                        // ilgili methoda ulaasip daha sonra istedigimiz methodu asagidaki sekilde kullaniyoruz
            S1.entryStudent(); // diger classta olusturdugumuz methodu bu sekilde cagiririz

            S1.StudentMethod("alan", "karaca");


            System.Threading.Thread.Sleep(2000);
       
        }

        static void Entry()
        {
            // static kelimesini methodu bir yerden cagirabilmek icin kullaniyoruz
            // void kelimesini kullanildiginda method calisacak ama geriye bir deger dondurmeyecektir.

            Console.WriteLine("karaca");
        }

    }
}

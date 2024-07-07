using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Encapsulation
{
    internal class Musteri  // internal classin public classtan farki; olusturulan namespace icerisinde kullanilabilmesi.
                            // public ise baska namespacelerden de cagirilabilir ve kullanilabilir. 
    {
        public Musteri()
        {
            this.id = IdUret();
        }

       
        int id;
        public int ID // class > property
        {
            get { return this.id; }
            private set { id = value; } // set kisminin kullanilmasini istemedigimiz zaman set'i private olarak ayarlariz.
                                        // bboylede disardan id atamasi yapilamaz.
        }


        public string name;
        public string surname;

        
        private string email;

        public string Email // class > property
        {
            set 
            {
                this.email=value;
            }

            get
            {
                return this.email;
            }

        }

        private int IdUret() 
        {
            Random rnd = new Random();
            return rnd.Next(10000,90000);
        }

    }
}

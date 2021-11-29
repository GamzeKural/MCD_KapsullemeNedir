using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            /*
             * Field değer ataması yapılmasın ama değer okunabilsin.
             * Field değer ataması yapılsın ama değer okunamasın. (geti private yapmak)
             * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde
             * ...bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
             * 
             */

            
            
            //Genel olarak kapsülleme konusuna giriş yaptık.
            M1.EmailAdres = "turanfaik@hotmail.com";
            Console.WriteLine(M1.EmailAdres);

            
            
            //1.Field değer ataması yapılmasın ama değer okunabilsin.
            Console.WriteLine("Müşteri ID değeri: "+M1.ID.ToString());
            //M1.ID = 10; (Buna izin vermiyor)



            M1.TCKimlikNumarası = "12254402599";
            string TC = M1.TCKimlikNumarası;
            Console.WriteLine(TC);
            
            //isim ve soyisim
            //isim ve soyisim[soyisim] set
            //email adresi...
            //email get faik.turan@hotmail.com
            //set private olduğunda set etmez
            M1.isim = "faik";
            M1.Soyisim = "turan";
            Console.WriteLine(M1.EmailAdres);






            Console.ReadKey();

        }
    }
}

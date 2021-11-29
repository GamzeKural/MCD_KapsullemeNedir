using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsullemeNedir
{
    class Musteri
    {
        //Class => Field
        int id;
        public string isim;
        public string soyisim;


        //Class => Property
        private string emailAdres;
        public string EmailAdres
        {
            //get; //databes veya farklı bir veri kaynağı class çağıran programcıya datayı
            //gösterdiğimiz alan.
            //set; //dış dünyadan alınan datanın içerisinde private olarak saklanan field
            //yani alan içerisine değer atandığı kısım...

            set
            {
                this.emailAdres = value;
            }

            get
            {
                return this.emailAdres;
            }
        }
    }
}

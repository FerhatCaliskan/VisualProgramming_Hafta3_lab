using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_lab
{
    internal class Kisiler
    {
        public string ad;
        public string soyad;
        public DateTime dogumTarihi;


        public int Yas()
        {
            int yas = DateTime.Now.Year - dogumTarihi.Year;

            if (DateTime.Now.Year < dogumTarihi.DayOfYear)
            {
                yas--;
            }
            return yas;
        }
        
        public string BilgileriYazdir()
        {
            return $"{ad} {soyad} - Yaş: {Yas()}";
        }
    }

}

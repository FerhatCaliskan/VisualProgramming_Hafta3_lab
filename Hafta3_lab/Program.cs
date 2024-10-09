using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToplaCarp Fonksiyonu 
            int sayi1;
            int sayi2;
            int toplam;
            int carpim;

            ToplaCarp n = new ToplaCarp();

            Console.WriteLine("Ilk degeri giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci degeri giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            n.Topla_Carp(ref sayi1, ref sayi2, out toplam, out carpim);

            Console.WriteLine(new string('-', 50));
            
            Console.ReadLine();

            //Kisileri Siralama Uygulaması

            List<Kisiler> KisiSiralama = new List<Kisiler>()
            {
                new Kisiler{ad = "Seyit", soyad ="Kılıç", dogumTarihi = new DateTime(2000 ,2, 2)},
                new Kisiler{ad = "Mustafa", soyad ="Çağlar", dogumTarihi = new DateTime(1999 , 4, 22)},
                new Kisiler{ad = "Kayra", soyad ="Kanıbir", dogumTarihi = new DateTime(2001 , 1, 14)},
                new Kisiler{ad = "Ferhat", soyad ="Çalışkan", dogumTarihi = new DateTime(2001 , 6, 23)},
                new Kisiler{ad = "Damla Nur", soyad ="Akcan", dogumTarihi = new DateTime(2004 , 6, 5)},
                new Kisiler{ad = "Şeyma ", soyad ="Özdemir", dogumTarihi = new DateTime(1998 , 3, 9)},
                new Kisiler{ad = "Ahmet", soyad ="Yılmaz", dogumTarihi = new DateTime(1995 , 12, 6)},
                new Kisiler{ad = "Mustafa", soyad ="Hacımahmutoğlu", dogumTarihi = new DateTime(1996 , 7, 14)},
                new Kisiler{ad = "Serkan", soyad ="Tezcan", dogumTarihi = new DateTime(1985 , 10, 29)},
                new Kisiler{ad = "Burhan ", soyad ="Aras", dogumTarihi = new DateTime(1997 , 5, 18)},

            };

            var siralanmisKisiler = KisiSiralama.OrderBy(k  => k.Yas()).ToList();

            Console.WriteLine("Kişilerin Sıralanmış Hali : ");
            foreach (var kisiler in siralanmisKisiler)
            {
                Console.WriteLine(kisiler.BilgileriYazdir());
            }
            
            Console.ReadKey();


        }
    }
}

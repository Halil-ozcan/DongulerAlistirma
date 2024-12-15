using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kullaniciadi = "admin";
            string sifre = "test";

            int hak = 3;

            while(hak > 0)
            {
                Console.WriteLine("Kullanici Adi : ");
                string GelenKullaniciAdi = Console.ReadLine();

                Console.WriteLine("Sifre : ");
                string GelenSifre = Console.ReadLine();

                if (kullaniciadi == GelenKullaniciAdi && sifre == GelenSifre)
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }
                else
                {
                    hak--;
                    Console.WriteLine("Giriş Başarısız Kalan Hakkınız : " + hak);
                }
                if(hak == 0)
                {
                    Console.WriteLine("Giriş Hakkınız Doldu");
                }
            }
            
           
        }
    }
}

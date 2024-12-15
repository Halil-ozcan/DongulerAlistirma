using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDonguAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("1-Toplma");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("5-Çıkış");

            string secim;

            while(true)
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seciniz");
                secim = Console.ReadLine();

                if(secim == "5")
                {
                    Console.WriteLine("Programdan Çıkılıyor");
                    break;
                }

                Console.WriteLine("Birinci Sayıyı Girin");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İkinci Sayiyi Girin");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;

                switch(secim)
                {
                    case "1":
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Sonuc : " + sonuc);
                        break;
                    case "2":
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Sonuc : " + sonuc);
                        break;
                    case "3":
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Sonuc : " + sonuc);
                        break;
                    case "4":
                       
                        if(sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("Sonuc : " + sonuc);
                        }
                        else
                        {
                            Console.WriteLine("Sıfıra Bölme Tanımsızdır");
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız");
                        break;
                   
                }
            }
        }
    }
}

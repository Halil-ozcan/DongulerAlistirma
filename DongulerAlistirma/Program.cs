using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] urunFiyat = new int[5];
            urunFiyat[0] = 100;
            urunFiyat[1] = 300;
            urunFiyat[2] = 500;
            urunFiyat[3] = 700;
            urunFiyat[4] = 1000;
            int toplam = 0;

            Console.WriteLine("Fatura Yazdırma Örneği");
            for (int i = 0; i<urunFiyat.Length; i++)
            {
                int urun = urunFiyat[i];
                Console.WriteLine("{0} . ürünün Fiyati : {1}", i , urun + " TL ");

                Console.WriteLine("--------------------------------------------");

                toplam = toplam + urun;
                
            }
            Console.WriteLine("Toplam Tutarınız : " + toplam + " TL ");



        }
    }
}

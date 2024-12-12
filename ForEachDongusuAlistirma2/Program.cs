using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusuAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] siparis = { "Telefon", "Kulaklık", "Laptop", "Bilgisayar", "Süpürge", "PowerBank" };

            int sayac = 1;
            int toplam = 0;
            foreach(var item in  siparis)
            {
                Console.WriteLine("{0}. sipariş Adı : {1}", sayac, item);
                sayac++;
               
            }
            toplam = siparis.Length;
            Console.WriteLine("Toplam Sipariş : " +  toplam);

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] calisan = new int[10];


            int maxMaas = calisan[0];
            int maxIndex = 0;
            for (int i = 0;  i < calisan.Length; i++)
            {
                calisan[i] = rnd.Next(18000,50000);
                int maas = calisan[i];
                Console.WriteLine("{0}. Çalışanın Maaşı : {1}", i+1, maas);
                if (calisan[i] > maxMaas)
                {
                    maxMaas = calisan[i];
                    maxIndex = i;
                }

                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("{0}. Çalışan Kişi En Yüksek Maaşı Alıyor: {1}", maxIndex + 1, maxMaas);








        }
    }
}

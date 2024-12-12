using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] OgrenciNot =  { 50, 85, 45, 90, 70, 60, 55, 65, 100, 40 };

            int ortalama = 0;
            int toplam = 0;
            int ortalamaAltındaKalan = 0;

            for(int i = 0; i < OgrenciNot.Length; i++)
            {
                int not = OgrenciNot[i];
                Console.WriteLine(not);

                toplam = toplam + not;
            }

            Console.WriteLine("----------------------------------------------------");

            ortalama = toplam / OgrenciNot.Length;

            for(int i = 0; i<OgrenciNot.Length; i++)
            {
                if (OgrenciNot[i] <  ortalama)
                {
                    ortalamaAltındaKalan++;
                }
            }

            Console.WriteLine("Notların Ortalaması: " + ortalama);
            Console.WriteLine("Ortalamanın Altında Kalan Öğrenci Sayısı: " + ortalamaAltındaKalan);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Ortalamanın Altında Kalan Öğrencilerin Notları:");

            for(int i = 0;i < OgrenciNot.Length;i++)
            {
                if (OgrenciNot[i] < ortalama)
                {
                    Console.WriteLine("{0}. Öğrenci Notu : {1}", i, OgrenciNot[i]);
                }
            }

        }
    }
}

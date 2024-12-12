using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = { "Yumurta", "Peynir", "Süt", "Sucuk", "Zeytin", "Salam" };
            int sayac = 1;
            foreach(var item in urunler)
            {
                Console.WriteLine("{0}. Ürün Adı : {1}", sayac, item);
                sayac++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{
    class ToplamaSinifi 
    {
        public int Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Tam sayı metotu çalıştı");
            return sayi1 + sayi2;
        }
        public double Topla(double sayi1, double sayi2)
        {
            Console.WriteLine("Ondalıklı sayı metotu çalıştı");
            return sayi1 + sayi2;
        }
        public string Topla(string metin1 , string metin2)
        {
            Console.WriteLine("String metotu çalıştı");
            return metin1 + metin2;
        }
    }
}

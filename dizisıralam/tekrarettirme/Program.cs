using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrarettirme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, a, b, c, d, e;
            Console.WriteLine("1.sayı= ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayı= ");
            sayi2 = int.Parse(Console.ReadLine());
            a = sayi1 + sayi2;
            b = sayi1 - sayi2;
            c = sayi1 * sayi2;
            d = sayi1 / sayi2;
            e = sayi1 % sayi2;
            int[] sonuclar = { a, b, c, d, e};
            int gecici;
            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    if (sonuclar[t] < sonuclar[i])
                    {

                        gecici = sonuclar[i];

                        sonuclar[i] =sonuclar[t];

                        sonuclar[t] = gecici;

                    }
                }
            }
            foreach (int i in sonuclar)
            {

                Console.WriteLine("{0}", i);

            }
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amicablenumber
{
    class Program
    {
        public static int Bolenbul(int bolunecek)
        {
            int bolumlerintoplami=0;
            int yedek;
            for(int i = 1; i < bolunecek; i++)
            {
                yedek = bolunecek / i;
                if (yedek * i == bolunecek)
                {
                    bolumlerintoplami = bolumlerintoplami + i;
                }
            }
            return bolumlerintoplami;
        }

        static void Main(string[] args)
        {
            int bolum;
            for(int i=100;i<10000000;i++)
            {
                bolum = Bolenbul(i);
                if (Bolenbul(bolum) == i)
                {
                    Console.WriteLine("1.sayı= " + i + " 2.sayı= " + bolum);
                   
                }
            }
            Console.ReadKey();
        }
      
    }
}

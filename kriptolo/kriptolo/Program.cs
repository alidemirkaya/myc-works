using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kriptolo
{
    class Program
    {
        static void Main(string[] args)
        {
            double abcd, a, b, c, d;
            
            for (a = 1; a < 10; a += 1)
            {             
                for (b = 0; b < 10; b += 1)
                {
                    for (c = 0; c < 10; c += 1)
                    {
                        for (d = 0; d < 10; d += 1)
                        {
                            abcd = a * 1000 + b * 100 + c * 10 + d;

                            if ((abcd == Math.Pow(a, a) + Math.Pow(b, b) + Math.Pow(c, c) + Math.Pow(d, d)) && (abcd>3500))
                            {
                                
                                Console.WriteLine(abcd);
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
            
            


        }
    }
}

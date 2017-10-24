using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascikodlari
{
    class Program
    {
        public struct siralama
        {
            public string kelime;
            public int numarasi;
            public siralama(string k1,int r1)
            {
                kelime = k1;
                numarasi = r1;
            }
        }
        public static string[] terssort(siralama[] numaralar)
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (numaralar[j].numarasi < numaralar[j - 1].numarasi)
                    {
                        int gecici = numaralar[j - 1].numarasi;
                        string yedek = numaralar[j - 1].kelime;
                        numaralar[j - 1].numarasi = numaralar[j].numarasi;
                        numaralar[j - 1].kelime = numaralar[j].kelime;
                        numaralar[j].numarasi = gecici;
                        numaralar[j].kelime= yedek;
                    }
                }
            }
            string[] dizi = new string[10];           
            for(int i = 0; i < 10; i++)
            {
                dizi[i] = numaralar[i].kelime;
            }
            return dizi;
        }
        static void Main(string[] args)
        {

            siralama[] kelimeler = new siralama[10];
            Console.WriteLine("10 tane Kelime Giriniz= ");
            for (int i = 0; i < 10; i++)
            {
                 kelimeler[i].kelime = Convert.ToString(Console.ReadLine());
                 kelimeler[i].numarasi = Kelimeler(kelimeler[i].kelime);
                 
            }
            Console.WriteLine("   ");
            string[] yazdir=terssort(kelimeler);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(yazdir[i]);
            }
            Console.ReadKey();
        }
        public static int Kelimeler(string islemealinacak)
        {
            char[] karakter;
            byte[] numarasi;
            int topla1,topla2,sonuc;
            sonuc = 0;
            topla1 = 0;
            topla2 = 0;
            karakter = islemealinacak.ToCharArray();
            numarasi = System.Text.Encoding.UTF8.GetBytes(karakter);
            for(int i = 0; i < 2; i++)
            {
                topla1 = numarasi[i] +topla1;
                
            }
            for(int j = karakter.Length-1; j > (karakter.Length) - 3; j--)
            {
                topla2 = numarasi[j] + topla2;
                
            }
            sonuc = topla1 * topla2;
            return sonuc;
        }
    }
}

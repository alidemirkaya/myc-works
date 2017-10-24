using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] karakter;
            // Öncelikle bir dizi tanımladık 
            // Girilen kelimeyi bir dizi haline getireceğiz
            // Sonrasında türü byte olan "numara" dizisine ASCI kodlarını göndereceğiz
            // Son olarak da ekrana yazdıracağız.
            byte[] numara;
            string girilen;
            Console.WriteLine("Kelimeyi Giriniz := ");
            girilen = Console.ReadLine();
            karakter = girilen.ToCharArray();           
            numara = System.Text.Encoding.UTF8.GetBytes(karakter);
            for(int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine(numara[i]);
            }
            
            Console.ReadKey();
        }
        /*char[] karakter;
        byte[] numara;
        string girilen;
        Console.WriteLine("Harf Giriniz:= ");
            girilen = Console.ReadLine();
            karakter = girilen.ToCharArray();
            int[] yeni = new int[karakter.Length];
        char[] yenikarakter = new char[karakter.Length];
        numara = System.Text.Encoding.UTF8.GetBytes(karakter);
            for(int i = 0; i<karakter.Length; i++)
            {
                yeni[i] = numara[i] + 1;
            }
            for(int j = 0; j<karakter.Length; j++)
            {
                yenikarakter[j] = Convert.ToChar(yeni[j]);
            }
            for(int i = 0; i<karakter.Length; i++)
            {
                Console.WriteLine(yenikarakter[i]);
            }
            Console.ReadKey();
            */
    }
}

using System;
using System.Data;
using System.Security.Cryptography;

namespace HesapMakinesi_Console
{
    // ayrı ayrı fonksiyonlar kullanarak toplama,çıkarma,çarpma,bölme işlemleri yapan hesap makinesi yapacağız ve hepsine 2 tane int değer göndereceğiz.
    class Program
    {

        /// <summary>
        /// 1. İŞLEM: TOPLAMA İŞLEMİ
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static void Topla(int s1, int s2)
        {
            Console.WriteLine("sayilarin toplamı \t  : {0}", (s1 + s2));
        }
        /// <summary>
        /// 2. İŞLEM: ÇIKARMA İŞLEMİ
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static void Çıkar(int s1, int s2)
        {
            Console.WriteLine("sayilarin farki \t : {0}", (s1 - s2));
        }
        /// <summary>
        /// 3. İŞLEM: ÇARPMA İŞLEMİ
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static void Çarp(int s1, int s2)
        {
            Console.WriteLine("sayilarin çarpimi \t : {0}", (s1 * s2));
        }
        /// <summary>
        /// 4.İŞLEM: BÖLME İŞLEMİ
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static void Böl(int s1, int s2)
        {
            Console.WriteLine("sayilarin bölümü \t : {0} ", (s1 / s2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayiyi giriniz:");    // kullanıcıdan ilk sayinin alinmasi
            int sayi1 = Convert.ToInt32(Console.ReadLine());  // alinan sayinin integer'a dönüştürülmesi

            Console.Write("ikinci sayiyi giriniz:");   // kullanicidan ikinci sayinin alinmasi    
            int sayi2 = Convert.ToInt32(Console.ReadLine()); // alinan sayinin integer'a dönüştürülmesi
            Console.WriteLine("---------------------------------------------------");
            Topla(sayi1, sayi2); //  Main metodu içinde Topla metodunun çağırılması.
            Çıkar(sayi1, sayi2); // Main metodu içinde Çıkar metodunun çağırılması.
            Çarp(sayi1, sayi2); // Main metodu içinde Çarp metodunun çağırılması.
            Böl(sayi1, sayi2); // Main metodu içinde Böl metodunun çağırılması.
            Console.WriteLine("----------------------------------------------------");
            Console.ReadKey();
        }

    }
}

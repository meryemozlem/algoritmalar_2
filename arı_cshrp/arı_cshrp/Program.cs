using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace arı_cshrp
{
    class ogrenci
    {
        public int no;
        public string ad, soyad;
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool s = (30 < 20);
            Console.WriteLine("Sonuç: " + s);

            //hata verir
            //int a = 5;
            //int a = 7;
            //ama yine main içinde 2 ayrı blok açsaydık hat olnazdı. yukarıda tek bir blok arasına yazdığımız için hata aldık.
            //aşağıdaki gibi bir kullnaım karar ve döngü yazpılarında kullanılır.
            /*
            { int a = 8; }
            { int a = 20; }*/

            //referans tipli değişkenler.
            //nesne tanımla. ogrenci. bu nesne ref. tiplidir.
            ogrenci ogrenci1 = new ogrenci();

            ogrenci1.no = 1559;
            ogrenci1.ad = "Ali";
            ogrenci1.soyad = "Öz";

            ogrenci ogrenci2 = new ogrenci();

            ogrenci2 = ogrenci1;

            ogrenci2.no = 147;
            ogrenci2.ad = "Veli";
            ogrenci2.soyad = "Türk";

            Console.WriteLine("1. öğrencinin no: {0}", ogrenci1.no);
            Console.WriteLine("1. öğrencinin adı: {0} soyadı: {1}", ogrenci1.ad, ogrenci1.soyad);

            int ay;
            string b = "5";
            ay = Convert.ToInt32(b);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}


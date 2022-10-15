using System;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1 den 100 e kadar olan sayıların toplamını bulan algoritma

            int toplam=0;
            for(int i=1; i<101; i++)
            {
                toplam+=i;
            }
            Console.WriteLine("Toplam sonucu: " + toplam);

           //  klavyeden girilen 10 sayının toplamının bulunması
            //  Toplam değişkeni ve sayaç ata

           int toplamm=0;
           int sayi;
           //int sayac=0;
           for(int sayac=0; sayac<11; sayac++)
           {
            Console.WriteLine("Sayı giriniz: ");
            sayi=Convert.ToInt16(Console.ReadLine());
            toplamm+=sayi;
           }
           Console.WriteLine("Toplam Sonucu: " + toplamm);

           //Sayı okuma ve toplama işlemlerinde sayaç ve toplam kullanılır.


        }
    }
}

using System;

namespace problems5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 10 adet sayının ortalamasını hesaplayan uygulama yazın.
            //10 sayının hepsini 10 tane tek tek yazamayız. Bunun için for döngüsü kullanırım. Sayıları almak ve toplamak için.
            
            int toplam=0;
            for(int i=0; i<10; i++)
            {
               Console.WriteLine("Sayı gir :");
               int sayi= Convert.ToInt32(Console.ReadLine());
               toplam+=sayi;
            }
            Console.WriteLine("Sayıların ortalaması = {0:N3}" , (toplam / 10));


            /* Hoca
            int toplam=0;
            for(int i=0; i<10 ; i++)
            {
                Console.WriteLine("Sayı gir: ");
                toplam+=Convert.ToInt32(Console.ReadLine()); //klavyeden okudukça sayıların toplamını buluyoruz.
            }

            Console.WriteLine("Sayıların ortalaması: " + toplam/10);
            */


        }
    }
}
using System;

namespace problems1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yarıçapı klavyeden girilen bir dairenin alanını hesaplayan uygulama yazın. Hesaplanan alanı ekrana 4 basamak ondalık hassasiyeti ile yazdırın.
            Console.WriteLine("Lütfen hesaplanmak istenen dairenin yarıçap değerini giriniz.");
            int r= Convert.ToInt32(Console.ReadLine());
            double pi=3.14;
            double alan=(pi*r*r);
            Console.WriteLine("Bu dairemin alanı: {0:N4}",alan);
        }
    }
}
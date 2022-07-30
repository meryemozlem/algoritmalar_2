using System;

namespace P002_CylinderVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Silindirin Hacmini Hesaplayalım.
            Hacim= piSayisi* yaricapin karesi * h(yükseklik)

            int r,h,hacim,pi;
            pi=3;
            Console.WriteLine("Yarıçapı giriniz.");
            r =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yüksekliği giriniz.");
            h =Convert.ToInt32(Console.ReadLine());
            hacim=(pi*r*r*h);
            Console.WriteLine("Hacim Hesaplandı: " + hacim);
            */

            int r,h;
            double pi =3.14159;
            Console.WriteLine("Yarıçapı giriniz.");
            r=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yüksekliği giriniz.");
            h=Convert.ToInt32(Console.ReadLine());

            double hacim =(pi*r*r*h);
            Console.WriteLine("Hacim Hesabı: {0:N2}", hacim);
        
        }
    }
}
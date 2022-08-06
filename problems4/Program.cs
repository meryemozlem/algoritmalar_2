using System;

namespace problems4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden iki vize ve final notu alınan öğrencinin yılsonu not ortalamasını hesaplayan uygulama yazın.Yılsonu notu, vize notlarının %30'u ve final notunun %40'ı alınarak hesaplanır.

            int vize1,vize2,final;
            double ort_;
            Console.WriteLine("Birinci vize notunuzu giriniz: ");
            vize1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci vize notunuzu giriniz: ");
            vize2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz: ");
            final=Convert.ToInt32(Console.ReadLine());
            ort_=(vize1*0.3)+vize2*0.3+final*0.4;
            Console.WriteLine("Yılsonu ortalamanız: " + ort_);

        }
    }
}
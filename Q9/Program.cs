using System;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 işlemi de yapan algoritmik menü
            double s1,s2;
            int deger;
            double topl,cikr,carp,bol;
            Console.Write("İlk sayı değerini giriniz.");
            s1=Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayı değerini giriniz.");
            s2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hangi işlemi yapmak istiyorsun? Toplama için 1, çıkartma için 2, çarpma için 3, bölme için 4 rakamını tuşla");
            deger=Convert.ToInt16(Console.ReadLine());
            if(deger==1)
            {
                topl=s1+s2;
                Console.Write("Toplama İşlemi Sonucu: " + topl);
            }
            else if(deger==2)
            {
                cikr=Math.Abs(s1-s2);
                Console.Write("Çıkartma işlemi sonucu: " + cikr);
            }
            else if(deger==3)
            {
                carp=s1*s2;
                Console.Write("Çarpma işlmei sonucu: " + carp);
            }
            else if(deger==4)
            {
                bol=s1/s2;
                Console.Write("Bölme işlemi sonucu: " + bol);
            }
            else
            {
                Console.WriteLine("Hatalı değer girişi.Tekrar deneyin.");
            }
        }
    }
}

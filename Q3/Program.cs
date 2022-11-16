using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üçgenin çevresini ve alanını bulan uygulama
            
            Console.WriteLine("Üçgenin çevresi için 1'e, alanı için 2'ye basınız: ");
            int cevap=Convert.ToInt16(Console.ReadLine());
            if(cevap==1)
            {
                Console.WriteLine("Üçgenin kenar uzunluklarını giriniz");
                int k1,k2,k3;
                k1=Convert.ToInt16(Console.ReadLine());
                k2=Convert.ToInt16(Console.ReadLine());
                k3=Convert.ToInt16(Console.ReadLine());
                int cevre=(k1+k2+k3);
                Console.WriteLine("Üçgenin çevresi=" + cevre );
            }

            else if(cevap==2)
            {   
                Console.WriteLine("Üçgenin taban uzunluğunu (cm) giriniz");
                int taban_uz;
                taban_uz=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Üçgenin yüksekliğini (cm) giriniz");
                int yukseklik=Convert.ToInt16(Console.ReadLine());
                int alan=(taban_uz*yukseklik)/2;
                Console.WriteLine("Alan :{0}" , alan);
                //Console.WriteLine("Üçgenin alanı: " + alan);
            }

            else
            {
                Console.WriteLine("Hatalı değer girişi, tekrar dene.");
            }
        }
    }
}

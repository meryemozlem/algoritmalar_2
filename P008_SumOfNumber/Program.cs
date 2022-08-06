using System;

namespace P008_SumOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verdiğin değişkenlere dikkat et. Değerlerin ona göre çağır ve kodların yukarıdan aşağıya doğru aktığını unutma.
            //Console.WriteLine("Girilen Sayıların Toplamını Bulan Uygulama");
            int sayi;
            int sum =0;
            do
            {
                Console.WriteLine("Bir sayı gir");
                sayi=Convert.ToInt32(Console.ReadLine());
                if(sayi!=-1)
                {
                    sum+=sayi;
                    //sum=sum +sayi;
                }
            }
            while(sayi != -1);     // while için { } açmadığımımz için ; koymak zorundayız.
            Console.WriteLine("Toplam:" + sum);


            /*
            Console.WriteLine(" Girilen Sayıların Toplamını Bulan Uygulama");
            int sayi=0;
            int sum=0;
            while(number != -1)//kosul
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sum+=number;
            }
            Console.WriteLine("Toplam:" + sum);
            */

        }
    }
}

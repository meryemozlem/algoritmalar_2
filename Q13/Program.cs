using System;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden 0 girilene kadar, girilen sayıları toplayan uygulama

            int sayi, toplam=0;
            while (true)
            {
                Console.Write("Sayı Gir : ");
                sayi = Convert.ToInt16(Console.ReadLine());
            
                if(sayi==0)
                {
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine("Girdiğiniz Sayıların Toplamı: "+toplam);
            
            
        }
    }
}
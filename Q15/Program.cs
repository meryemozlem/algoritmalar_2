using System;

namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen sayının asal olup olmadığını bulan uygulama
            // asal= /kendisi   /1  >1
            
            Console.Write("1 sayı giriniz: ");
            int sayi=Convert.ToInt16(Console.ReadLine());
            int sayac=0;

            for(int i=1;i<=sayi;i++)
            {
                if (sayi%i==0)
                {
                    sayac++;
                }
                
            }
            if(sayac==2)
            {
                Console.WriteLine("Girdiğin {0} Sayısı asaldır." , sayi);
            }
            else
            {    
                Console.WriteLine("Girdiğin {0} Sayı asal değildir" , sayi);
            }    
        }
    }
}
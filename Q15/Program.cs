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
            int bol;

            for(int i=1;i<=sayi;i++)
            {
                bol=(sayi/i);
                
            }
            Console.WriteLine("Cevap: " + bol);
            //Consoel.Write("BU sayı diğer say");
            
        }
    }
}

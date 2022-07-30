using System;

namespace P001_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        /*Dikdörtgende alan hesabı yapan uygulama*/
        {
            /*
            int a,b,alan;
            a=5;
            b=10;
            alan=(a*b);
            Console.WriteLine("Alan Hesabı: "+ alan);
            */
            
            
            int a,b,alan;

            Console.WriteLine("Dikdörtgenin Kısa Kenarını Giriniz: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin Uzun Kenarını Giriniz: ");
            b=Convert.ToInt32(Console.ReadLine());

            alan=(a*b);
            Console.WriteLine("Alan Hesabı: "+alan);
            
        
            
        }
    }
}

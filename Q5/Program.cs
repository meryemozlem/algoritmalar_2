using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //birleştirme op. metinsellerde
            Console.Write("Adınızı giriniz: ");
            string ad=Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            string soyad=Console.ReadLine();
            Console.WriteLine("Merhaba " + ad + " " + soyad + " Seni tekrar görmek harika.");
        }
    }
}
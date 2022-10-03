using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Algoritma Kitabı 1. En hızlı ve en kolay çözüm yolu.
            //Sayaç=sayaç+1 
            //Klavyeden girilen iki sayının okunarak toplanması
            // başla    1.sayıyı al     2.sayıyı al     topla   yazdır      bitir

            //Ohm kanununu çözen algoritma  V=I*R
            double akim,volt,direnc;
            Console.WriteLine("Devrenin akım değerini giriniz: ");
            akim=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Devrenin direç değerini giriniz: ");
            direnc=Convert.ToDouble(Console.ReadLine());
            volt=akim*direnc;
            Console.WriteLine("Sonuç: " + volt +" Volttur");


        }
    }
}

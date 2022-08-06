using System;

namespace problems3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen bir sayının mutlak değerini bulan uygulama yazın.
            Console.WriteLine("Bir sayi girin mutlak değerini bulayım: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int mutlak;
            if(sayi<0)
            {
                mutlak=sayi*(-1);
                Console.WriteLine("Mutlak değer: " + mutlak);
            }
            else
            {
                mutlak=sayi*1;
                Console.WriteLine("Mutlak değeri: " + mutlak);
            }
            
            //2.yol
            /*
            Console.WriteLine("Bir sayi girin mutlak değerini bulayım: ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a<0)
            {
                a=a*-1;
            }
            Console.WriteLine("Mutlak değer: " + a);
            */
        }
    }
}

using System;

namespace P006_LessThanTenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // && ve kontolü
            // || veya kontrolü
            
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi =Convert.ToInt32(Console.ReadLine());
            if(sayi<10 && sayi%2 != 0 ) // sayi%2==1
            {
                Console.WriteLine("Girdğin sayı {0} : 10 dan küçük ve tek. ", sayi);
                
            }
            else
            {
                Console.WriteLine("Girdiğin sayı çift veya 10 dan büyük.");
            }

        }
    }
}

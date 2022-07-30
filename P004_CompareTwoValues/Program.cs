using System;

namespace P004_CompareTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk değeri gir");
            int sayi1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci değeri gir");
            int sayi2 =Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2)
            {
                Console.WriteLine("{0} değeri {1}  değerinden büyüktür." , sayi1,sayi2 );
            }

            else // eşit veya sayi2 nin big olma durumu
            {
                if (sayi2>sayi1)
                {
                    Console.WriteLine("{0} değeri {1}  değerinden büyüktür." , sayi2,sayi1 );
                }
                else
                {
                    Console.WriteLine("İki değer birbirine eşittir.");
                }
            }
        }
    }
}

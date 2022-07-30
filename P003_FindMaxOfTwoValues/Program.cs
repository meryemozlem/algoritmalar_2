using System;

namespace P003_FindMaxOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1,sayi2;

            Console.WriteLine("İlk sayı değerini giriniz: ");
            sayi1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayı değerini giriniz: ");
            sayi2 =Convert.ToInt32(Console.ReadLine());

            if (sayi2>sayi1)
            {
                //Console.WriteLine("Sayı2 değeri büyük.");
                Console.WriteLine("Büyük olan değer: " + sayi2);
            }

            else if (sayi1 == sayi2)
            {
                Console.WriteLine("Sayılar birbirine eşittir.");
            }

            else // sayi1 ve sayi2 değerleri eşit olabilir ya da sayi2 değeri sayi1 den küçük olur.
            {
                //Console.WriteLine("Sayı 1 değeri büyüktür.");
                Console.WriteLine("Büyük olan değer: " + sayi1);
            }


        }
    }
}

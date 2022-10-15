using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının tek mi yoksa çift mi olduğunu bulan algoritma

            Console.Write("Bir değer gir: ");
            int deger=Convert.ToInt16(Console.ReadLine());
            if(deger%2==0)
            {
                Console.WriteLine("Değer çift sayıdır.");
            }
            else if (deger%2!=0) // deger%2==1
            {
                Console.WriteLine("Değer tek sayıdır.");
            }

        }
    }
}

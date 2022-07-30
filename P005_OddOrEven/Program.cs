using System;

namespace P005_OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Tek mi Çift mi olduğunu bulmak istediğin sayıyı gir: ");
            int deger = Convert.ToInt32(Console.ReadLine());
            if(deger%2 == 0)
            {
                Console.WriteLine("{0} değeri çifttir." ,deger);
            }
            else
            {
                Console.WriteLine("{0} değeri tektir." ,deger);
            }
            */


            Console.WriteLine("Bir sayı değeri ver: ");
            int deger =Convert.ToInt32(Console.ReadLine());
            string result;

            if( deger % 2 == 0)
            {
                result="çift";
            }
            else
            {
                result="tek";
            }

            Console.WriteLine("Sayı:" + result);
        }
    }
}

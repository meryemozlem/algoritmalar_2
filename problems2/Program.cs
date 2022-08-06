using System;

namespace problems2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden a ve b sayıları giriliyor. Girilen a sayısının b sayısının tam katı olup olmadığını bulan uygulama yazın.
            Console.WriteLine("Bir tamsayı a değeri girin");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir tamsayı b değeri girin");
            int b=Convert.ToInt32(Console.ReadLine());
            if(a%b==0)
            {
                //Console.WriteLine("A sayısı B sayısının tam katıdır.");
                Console.WriteLine(a+" sayısı "+b+" sayısının tam katıdır.");
            }
            else
            {
                Console.WriteLine("A sayısı B sayısının tam katı değildir.");
                //Console.WriteLine(a + " sayısı "+ b+" sayısının tam katı değildir.");
            }
        }
    }
}

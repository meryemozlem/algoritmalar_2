using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dairenin alanını ve kürenin hacmini hesaplayan uygulama
            //double pi=Math.PI;
            
            Console.Write("Dairenin yarıçapını giriniz: ");
            int y_cap=Convert.ToInt16(Console.ReadLine());
            double alan=(Math.PI*Math.Pow(y_cap,2));
            Console.WriteLine("Sonuç: {0}" , alan);
            Console.WriteLine("Sonuç: " + Math.Round(alan,2));

            Console.Write("Kürenin yarıçapını giriniz: ");
            int r=Convert.ToInt16(Console.ReadLine());
            double hacim=(4/3)* Math.PI *Math.Pow(r,3);
            Console.WriteLine("Sonuç: " + Math.Round(hacim,4));

        }
    }
}
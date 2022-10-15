using System;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {//int mutlakDeger=Math.Abs(int sayi);
            //Klavyeden girilen 10 sayıdan kaçının negatif, kaçının pozitif olduğunu bulan uygulama

            int sayi;
            int neg=0;
            int poz=0;
            for(int i=1; i<=10; i++)
            {
                Console.Write(i + ". sayıyı giriniz:");
                sayi=Convert.ToInt16(Console.ReadLine());
                if(sayi<0)
                {
                    neg++;
                }
                else if(sayi>0)
                {   
                    poz++;
                }
            }
            
            Console.WriteLine("Toplam pozitif sayı: " + poz);
            Console.WriteLine("Toplam negatif sayı: " + neg);
        }
    }
}

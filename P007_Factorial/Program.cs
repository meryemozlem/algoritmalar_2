using System;

namespace P007_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*temel bir soru olmasına rağmen çok önemli. Özümse.*/
            /*Console.WriteLine("Faktöriyelini hesaplamak istediğin sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int factorial=1;
            while(sayi>1)
            {
                factorial=sayi*factorial;
                sayi=sayi-1;    //sayi-=1 sayidan bir çıkar ve yeniden sayı değerine ata.
            }

            Console.WriteLine("Sonuç faktöriyeli: " + factorial);
            */
            
            /*Console.WriteLine("Faktöriyelini hesaplamak istediğin sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int factorial=1;
            int i=1;

            for(i=1;i<=sayi;i++)
            {
                factorial=factorial*1;
                
            }
            Console.WriteLine("Cevap: " + factorial);*/

            /*int sayi,i,f=1;
            Console.WriteLine("Faktoriyeli alınacak sayı girin");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (i=1; i <= sayi; i++)
            {
 
                f= i * f;
 
            }
            Console.WriteLine("Cevap : " + f);
 
            Console.ReadLine();
            */







        Console.WriteLine("Bana bir değer ver faktöriyelini bulayım.");
        int deger = Convert.ToInt32(Console.ReadLine());
        int factorial=1;
        while(deger>1)
        {
            factorial*=deger;
            deger=deger-1;
        }
        Console.WriteLine("sonuc: " + factorial);




/*
Console.WriteLine("Bir sayı gir faktöriyelini bulayım.");
int sayi=Convert.ToInt32(Console.ReadLine());
int f=1;
while(sayi>1)
{
    f=f*sayi;
    sayi=sayi-1;
}
Console.WriteLine("Girilen değerin faktöriyeli: " + f);
*/

















        }
    }
}

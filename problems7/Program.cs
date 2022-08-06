using System;

namespace problems7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı 1 ile 100 arasında sayı girene kadar tekrar giriş yapmasını isteyen bir uygulama yazın.
            /*1'den küçükse "Girdiğiniz sayı 1'den küçük. Tekrar deneyin.",
            100'den büyükse "Girdiğiniz sayı 100'den büyük. Tekrar deneyin.",
            1-100 arasındaysa "Teşekkürler! 1 ile 100 arasında bir sayı girdiniz."

            Console.WriteLine("Sayı değeri girin: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if(sayi<1)
            {
                Console.WriteLine(" Girdiğiniz sayı 1'den küçük. Tekrar deneyin. ");
            }
            else if(sayi>100)
            {
                Console.WriteLine(" Girdiğiniz sayı 100'den büyük. Tekrar deneyin. ");
            }
            else if (1>=sayi || sayi<=100)
            {
                Console.WriteLine(" Teşekkürler! 1 ile 100 arasında bir sayı girdiniz. ");
            }
            /*else
            {
                Console.WriteLine(" Girdiğiniz sayı b ");   
            }*/


            // 2.yol
            int sayi;
            do{
                Console.WriteLine("Sayı değeri girin: ");
                sayi=Convert.ToInt32(Console.ReadLine());

                if(sayi<1)
                {
                    Console.WriteLine(" Girdiğiniz sayı 1'den küçük. Tekrar deneyin. ");
                }
                else if(sayi>100)
                {
                    Console.WriteLine(" Girdiğiniz sayı 100'den büyük. Tekrar deneyin. ");
                }
                else     // 2 koşulu da sağlamıyorsa, sayı aralık arasındadır.
                {
                    Console.WriteLine(" Teşekkürler! 1 ile 100 arasında bir sayı girdiniz. ");
                }
            }
            while(sayi<1 || sayi>100);
        }
    }
}

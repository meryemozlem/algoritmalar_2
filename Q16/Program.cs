using System;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            // * * *
            // klavyeden girilen elektrik tüketim miktarı ve birim fiyata (kw/s) göre aylık tüketim faturasını hesaplayan uygulama
            // fatura=(tüketim * birim fiyat)
            //istersek fatura diye bir değişken tanımlamayız, fatura yerine hep çarpımları koyarız.
            // str olarak aldığımı int e çevirdim.


            double tuketim,birimFiyat,fatura;
            Console.Write("Tüketim miktarını (kw) giriniz: ");
            tuketim=Convert.ToInt32(Console.ReadLine());
            Console.Write("Birim fiyatı (kw/s) giriniz: ");
            birimFiyat=Convert.ToInt32(Console.ReadLine());
            fatura=(tuketim*birimFiyat);
            Console.WriteLine("Fatura: {0}" , fatura);

        }
    }
}
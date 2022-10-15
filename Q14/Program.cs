using System;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen 10 sayıdan tek olanların karelerinin toplamının, çift olanlarınsa küplerinin toplamını bulan algoritma
            /*
            basla
            sayi oku
            sayac+=1
            eger sayi mod 2=1 ise tek++ ve tekare=tekare+sayi^2
            eger sayi mod2=0 ise ciftkup=ciftkup+sayi^3
            eger sayac<20 ise git adım 2
            yaz teklerin cevabı
            yaz ciftlerin cevabı
            */

            int tek=0;
            int cift=0;
            double ciftkup=0;
            double tekare=0;

            for(int i=1; i<11; i++)
            {
                Console.Write(i+". sayıyı giriniz.");
                int sayi=Convert.ToInt16(Console.ReadLine());
                
                if(sayi%2==0)
                {
                    cift++;
                    ciftkup+=(Math.Pow(sayi,3));
                }
                else if(sayi%2!=0)
                {
                    tek++;
                    tekare+=(Math.Pow(sayi,2));
                }

                
            }
                Console.WriteLine("Toplam " + cift + " tane çift sayı var. Küpleri toplamı: " + ciftkup);
                Console.WriteLine("Toplamda " + tek + " tane tek sayı var. Kareleri toplamı: " + tekare);
        }
    }
}

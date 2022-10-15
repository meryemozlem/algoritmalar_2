using System;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 10 sayıdan kaçının tek,kaçının çift olduğunu bulan uygulama

            int tek=0;
            int cift=0;

            for(int i=1; i<11; i++)
            {
                Console.Write(i+". sayıyı giriniz.");
                int sayi=Convert.ToInt16(Console.ReadLine());
                if(sayi%2==0)
                {
                    cift++;
                }
                else if(sayi%2!=0)
                {
                    tek++;
                }

                
            }
            Console.WriteLine("Toplam " + cift + " tane çift sayı var.");
                Console.WriteLine("Toplamda " + tek + " tane tek sayı var.");
        }
    }
}

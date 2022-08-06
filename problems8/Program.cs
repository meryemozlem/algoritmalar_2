using System;

namespace problems8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir dizideki en küçük elemanı bulan uygulama yazın.Dizi boyutu: 10 Dizi elemanları : 8, 7, 9, 17, 3, -5, -1, 6, 20, 13
            int []sayilar=new int [10] {8, 7, 9, 17, 3, -5, -1, 6, 20, 13};
            int min_deger=0;
            int a;

            for(int i=0; i<10 ; i++ )
            {
                a=sayilar[i];
                if (a < min_deger)
                {
                    min_deger=a;
                }
            }

            Console.WriteLine("En düşük not: " + min_deger);


            /*
            int [] sayilar= new int [10] {8, 7, 9, 17, 3, -5, -1, 6, 20, 13};
            int minik=sayilar[0];

            for (int i=0; i<10; i++)
            {
                if(minik>sayilar[i])
                {
                    minik=sayilar[i];
                }
            }
            Console.WriteLine("En düşük not: " + minik);
            */

        }
    }
}
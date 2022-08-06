using System;

namespace P009_BestGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Dersten alınan en iyi notu bulan uygulama. 3 not arasından en büyüğünü bulsun. 1 2   1 3   2 3
            //şimdi her öğrenci için bir değişken tanımlamak ve üerinde işlem yapmak if else ile tek tek zordur. Bunun kısa bir yolu yok mu? Tabii ki var. Dizi kullanmak.
            /*int grade1= 50;
            int grade2= 85;
            int grade3 =60;

            if(grade1>grade2)
            {
                if(grade1>grade3)
                {
                    Console.WriteLine("En büyük değer: " + grade1);
                }
                else
                {
                    Console.WriteLine("En büyük değer: " + grade3);
                }
            }
            
            else
            {
                if(grade2>grade3)
                {
                    Console.WriteLine("En büyük değer: " + grade2);
                }
                else
                {
                    Console.WriteLine("En büyük değer: " + grade3);
                }
            }
            


            int [] grades=new int[3] {90,85,95};
            int maxGrade=0;

            for(int i=0; i<3; i++)
            {
                if(grades[i]>maxGrade)
                {
                    maxGrade=grades[i];
                }
            }
            Console.WriteLine(En yüksek not: " + maxGrade);
            
            
            
            
            */

            int [ ] grades =new int [3] {90,85,95};
            // int tanımlamak için grades[0]=90; grades[1]=85 grades[2]=95; de yazılabilirdi.
            int maxGrade=0;
            int a;

            for(int i=0; i<3; i++)  //i<=2 de olurdu.
            {
                a = grades[i];
                if(a>maxGrade)
                {
                    maxGrade=a;
                }
            }
            Console.WriteLine("En yüksek not: " + maxGrade);
            

        }
    }
}
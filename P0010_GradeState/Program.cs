using System;

namespace P0010_GradeState
{
    class Program
    {
        static void Main(string[] args)
        {
            // dersin harf notun dağılımını hesaplayan uygulama. ABCDF kaç öğrenci a kaç öğrenci b aldı diye hesaplasın.
            string [] grades=new string [12] {"A","B","C","D","F","C","B","a","D","F","A","B"};
            int [] statics=new int[5]; //a b c d f için. 0=a 1=b 4=f
            for(int i=0; i<12; i++)
            {
                switch (grades[i])
                {
                    case "A":
                    case "a":
                    statics [0]=statics[0]+1;
                    break;
                    case "B":
                    case "b":
                    statics [1]+=1;
                    break;
                    case "C":
                    case "c":
                    statics [2]++;
                    break;
                    case "D":
                    case "d":
                    statics [3]++;
                    break;
                    case "F":
                    case "f":
                    statics [4]++;
                    break;
                }
            }

            Console.WriteLine("Öğrencilerin sırasıyla harf notu dağılımı: ");
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(statics[i]);
            }
        }
    }
}
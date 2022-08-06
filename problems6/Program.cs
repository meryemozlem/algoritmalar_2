using System;

namespace problems6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 ile 50 arasındaki (ikisi de dahil) tek ve dörde bölünebilen sayıları listeleyen bir uygulama yazın.
            for(int i=1; i<=50; i++)
            {   
                if( i%2==1 || i%4==0)
                {
                    Console.WriteLine("Sayılar: " + i);
                }
                
            }
        }
    }
}

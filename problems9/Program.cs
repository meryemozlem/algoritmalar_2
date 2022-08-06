using System;

namespace problems9
{
    class Program
    {
        static void Main(string[] args)
        {
            double anaPara=10000;
            double faiz_orani=0.1;
            int yil=5;

            for(int i=1;i<=yil;i++)
            {   
                anaPara= anaPara * (1+faiz_orani);
                Console.WriteLine(i +". yıl sonunda toplam anapara: {0:N2}" ,anaPara);
            }
            
        }
    }
}

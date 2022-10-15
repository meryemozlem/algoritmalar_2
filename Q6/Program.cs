using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            // KLAVYEDEN GİRİLEN 2 SAYIDAN BİG OLANINI BUL VE 7 İLE ÇARP 
            int islem;
            Console.Write("ilk sayıyı giriniz: ");
            int ilk=Convert.ToInt16(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz: ");
            int ikinci=Convert.ToInt16(Console.ReadLine());

            if(ilk>ikinci)
            {
                Console.WriteLine("İlk değer bigdir");
                islem=ilk*7;
                Console.WriteLine("Sonuç: " + islem);
            }

            else if(ikinci>ilk)
            {
                Console.WriteLine("İkinci değer bigdir.");
                islem=ikinci*7;
                Console.WriteLine("Sonuç: " + islem);
            }

            else if(ilk==ikinci)
            {
                Console.WriteLine("İki değer de birbirine eşittir.");
            }
        }
    }
}

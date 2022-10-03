using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //celcius cinsinden girilen sıcaklığın fahrenheit ve kelvin cinsinden hesaplanması

            double celcius,fahrenheit,kelvin;
            Console.WriteLine("Dönüşüm yapılacak olan sıcaklığı celcius cinsinden giriniz: ");
            celcius=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hangi değere dönüştürmek istiyorsun? Fahrenheit ise 1, kelvin ise 2'ye bas");
            int cevap=Convert.ToInt16(Console.ReadLine());
            if(cevap==1)
            {
                fahrenheit=(1.8*celcius)+32;
                Console.WriteLine("Cevap= " +  fahrenheit);
            }
            
            else if(cevap==2)
            {
                kelvin=celcius+273.15;
                Console.WriteLine("Cevap:  "+ kelvin);
            }

            else
            {
                Console.WriteLine("Hatalı değer girdin. Tekrar dene.");
            }
            
            
        }
    }
}
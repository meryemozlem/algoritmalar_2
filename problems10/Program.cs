using System;

namespace problems10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden 1-7 arası girilen sayının hangi gün olduğunu bulan bir uygulama yazın.Klavyeden 1-7 aralığı dışında bir sayı girilirse kullanıcıya hata mesajı gösterilmeli ve tekrar giriş yapması istenmelidir.
            //1: Pazartesi 2: Salı 3: Çarşamba 4: Perşembe 5: Cuma 6: Cumartesi 7: Pazar Diğer ihtimaller için: Hatalı giriş

            /*
            Console.WriteLine("1-7 arasında değer gir ve hangi gün olduğunu bulayım: ");
            int deger=Convert.ToInt32(Console.ReadLine());
            switch(deger)
            {
                case 1:
                Console.WriteLine("Pazartesi");
                    break;
                case 2:
                Console.WriteLine("Salı");
                    break;
                case 3:
                Console.WriteLine("Çarşamba");
                    break;
                case 4:
                Console.WriteLine("Perşembe");
                    break;
                case 5:
                Console.WriteLine("Cuma");
                    break;
                case 6:
                Console.WriteLine("Cumartesi");
                    break;
                case 7:
                Console.WriteLine("Pazar");
                    break;
                default:
                Console.WriteLine("Hatalı giriş yaptınız,tekrar deneyiniz.");
                    break;
            }
*/
            
            int gun;
            do{
                Console.WriteLine("1-7 arasında sayı gir: ");
                gun=Convert.ToInt32(Console.ReadLine());
                switch(gun)
                {
                    case 1:
                        Console.WriteLine("Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine("Salı");
                        break;
                    case 3:
                        Console.WriteLine("Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine("Perşembe");
                        break;
                    case 5:
                        Console.WriteLine("Cuma");
                        break;
                    case 6:
                        Console.WriteLine("Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine("Pazar");
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş");
                        break;
                }
            }

            while(gun<1 || gun>7);     //döngüden çıkmamızı sağlar.


        }
    }
}
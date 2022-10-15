using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vize ve final notunu al. ortalamayı hesapla.başarısızsa büt iste.büt 50 altındaysa kaldın de.değilse geçtin de. 
            //vizenin %30'u finalin %70'i alınır ve dersi geçme notu 50'dir.

            int vize,final,but;
            double ort;

            Console.Write("Vize notunu giriniz: ");
            vize=Convert.ToInt16(Console.ReadLine());
            Console.Write("Final notunu giriniz:");
            final=Convert.ToInt16(Console.ReadLine());
            ort=(vize*0.3)+(final*0.7);
            if(ort>=50)
            {
                Console.WriteLine("Tebrikler! Dersten geçtin.");
            }
            else
            {
                Console.Write("Büt notunu gir: ");
                but=Convert.ToInt16(Console.ReadLine());
                if (but>=50)
                {
                    ort=(vize*0.3)+(but*0.7);
                    Console.WriteLine("Tebrikler! " + Math.Round(ort,3)+ " ile geçtin.");
                }
                else
                {
                    Console.Write("Üzgünüz, dersten " + Math.Round(ort,2) + " ile kaldınız.");
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitleIndeksiHesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            KitleIndeksiHesapla();
            Console.ReadKey();
        }

        private static void KitleIndeksiHesapla()
        {
            Console.WriteLine("Cinsiyet giriniz(bay/bayan): ");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Boyunuzu cm olarak giriniz: ");
            double boy = double.Parse(Console.ReadLine());

            Console.WriteLine("Kilonuzu giriniz: ");
            double kilo = double.Parse(Console.ReadLine());

            double metre = boy / 100;
            double vki = kilo / (metre*metre);
            Console.WriteLine(metre);
            Console.WriteLine(vki);

            switch(cinsiyet) 
            {
                case "bayan":
                    Console.WriteLine(vki<18.5 ? "zayıf" : vki<24.9 ? "Normal ağırlıkta" : vki<29.9 ? "kilolu": vki<34.9 ? "1.derece obez": "2.derece obez");
                    break;
                case "bay":
                    Console.WriteLine(vki < 19.5 ? "zayıf" : vki < 25.9 ? "Normal ağırlıkta" : vki < 30.9 ? "kilolu" : vki < 35.9 ? "1.derece obez" : "2.derece obez");
                    break;
                default:
                    Console.WriteLine("'bay' veya 'bayan' giriniz");
                    break;
            }

        }
    }
}

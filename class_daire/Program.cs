using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_daire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("yaricapi giriniz: ");
            int yaricap = int.Parse(Console.ReadLine());

            Console.WriteLine("Cevre:"+ Daire.CevreHesapla(yaricap));

            Console.WriteLine("Alan:" + Daire.AlanHesapla(yaricap));

            Console.ReadKey();
        }
    }

    class Daire
    {
        public static double CevreHesapla (int r)
        {
            double cevre = 2 * 3.14 * r;

            return cevre;
        }

        public static double AlanHesapla(int r)
        {
            double alan = 3.14 * r * r;

            return alan;
        }
    }
}

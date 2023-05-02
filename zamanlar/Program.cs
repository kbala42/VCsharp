using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            var tms = Environment.TickCount; // Sistem başlatıldığından beri geçen zaman
            var milisaniye  = tms / 1000; // milisaniye
            var dakika = milisaniye / 60;// dakika
            var saat = dakika / 60;// saat
            Console.WriteLine(saat + " saat geçti");

            int yil = DateTime.Today.Year;
            int ay = DateTime.Today.Month;
            int gun = DateTime.Today.Day;

            Console.WriteLine(gun+"/"+ay+"/"+yil);
            Console.ReadKey();
        }
    }
}

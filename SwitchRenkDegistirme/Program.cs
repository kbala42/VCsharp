using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchRenkDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            switchRenkDegistir();
            Console.ReadLine();
        }

        private static void switchRenkDegistir()
        {
            Console.WriteLine("Önceki yazı rengi");
            ConsoleColor arkaplanRengi = Console.BackgroundColor;

            switch(arkaplanRengi)
            {
                case ConsoleColor.Black:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case ConsoleColor.White:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
        }
    }
}

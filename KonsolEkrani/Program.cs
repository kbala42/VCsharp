using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolEkrani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Baslik";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.CursorSize = 60;
            Console.CursorTop = 120;
            Console.CursorLeft = 100;

            Console.WriteLine("Merhaba");
            Console.ReadKey();
        }
    }
}

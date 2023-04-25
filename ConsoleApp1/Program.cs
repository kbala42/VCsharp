using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc=1;

            Console.Write("faktoryeli bulacagimiz sayi:");
            int sayi = int.Parse(Console.ReadLine());

            for(int i=1; i<=sayi; i++)
            {
                sonuc *= i;
            }
            Console.WriteLine(sayi + " sayisinin faktoryeli: " + sonuc);

            Console.ReadKey();
        }
    }
}

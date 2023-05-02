using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int yasYil = yasiBul();
            Console.WriteLine("Yaşınız "+ yasYil+" dır.");
            resitMi(yasYil);
            Console.ReadKey();
        }

        private static void resitMi(int yasYil)
        {
            if (yasYil > 18)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Reşit");
                
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Reşit değil");                
            }
        }

        private static int yasiBul()
        {
            return DateTime.Today.Year - dogumYili();
        }

        private static int dogumYili()
        {
            Console.Write("Doğum yılınızı giriniz: ");
            return int.Parse(Console.ReadLine());
        }
    }
}

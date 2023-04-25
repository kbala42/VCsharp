using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalMi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());  

            bool asalMi = false;
            

            for (int sayac = 2; sayac <= sayi / 2; sayac++)
            {
                if (sayi % sayac == 0) // sayi, sayac'in o anki iceregine tam bolunuyorsa asal degildir
                {
                    asalMi = true;
                     
                    Console.WriteLine(sayi + " asal bir sayi degildir");
                    break;
                }
            }

            if (asalMi == false) Console.WriteLine(sayi + " asal bir sayidir");

            Console.ReadKey();
          
        }
    }
}

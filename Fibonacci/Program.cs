using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilk = 0, son = 1; // ilk iki elenai giriyoruz
            int yeni;// Sirada ki hesaplayacagimiz eleman

             Console.Write("Kacinci elemana kadar hesaplayacagiz:");
            int nEleman = int.Parse(Console.ReadLine()); // Kacinci elemana kadar hesaplanacak

            for (int sayac = 0; sayac < nEleman; sayac++)
            {
                Console.Write(ilk + " ");
                yeni = ilk + son;
                ilk = son;
                son = yeni;
            }
            Console.ReadKey();
        }
    }
}

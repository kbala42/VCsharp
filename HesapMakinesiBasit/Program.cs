using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiBasit
{
    class Program
    {
        static void Main(string[] args)
        {
            tekrar:
            Console.WriteLine("Hesap makinesi");
            Console.Write("Birinci sayıyı giriniz: "); int sayiBir = int.Parse(Console.ReadLine());
            Console.Write("Ikinci sayıyı giriniz: "); int sayiIki = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplamak için  + tuşuna");
            Console.WriteLine("Çıkartmak için - tuşuna");
            Console.WriteLine("Çarpma için    * tuşuna");
            Console.WriteLine("Bölmek için    / tuşuna");
            Console.WriteLine("basınız");
            String secim = Console.ReadLine();
            int sonuc;
            switch(secim)
            {
                case "+":
                    sonuc = sayiBir + sayiIki;
                    Console.WriteLine(sayiBir + " + " + sayiIki+ " =" + sonuc );
                    break;

                case "-":
                    sonuc = sayiBir - sayiIki;
                    Console.WriteLine(sayiBir + " + " + sayiIki + " =" + sonuc);
                    break;

                case "*":
                    sonuc = sayiBir * sayiIki;
                    Console.WriteLine(sayiBir + " + " + sayiIki + " =" + sonuc);
                    break;

                case "/":
                    sonuc = sayiBir / sayiIki;
                    Console.WriteLine(sayiBir + " + " + sayiIki + " =" + sonuc);
                    break;

            }
            goto tekrar;
        }
    }
}

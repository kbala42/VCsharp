using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiBasit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Basit Hesap Makinesi - Kamil Bala";
            devam:
                Console.WriteLine(@"
                                    ----------------------------
                                        Basit Hesap makinesi 
                                    ----------------------------
                                    ");

                Console.Write("Birinci sayıyı giriniz: "); 
                double sayiBir = Double.Parse(Console.ReadLine());

                Console.Write("Ikinci sayıyı giriniz: ");
                double sayiIki = Double.Parse(Console.ReadLine());

                Console.WriteLine(@"
                                    Toplamak için  + tuşuna 
                                    Çıkartmak için - tuşuna 
                                    Çarpma için    * tuşuna 
                                    Bölmek için    / tuşuna


                                    basınız");
                
                double sonuc;

            
                var info = Console.ReadKey();
                Console.WriteLine();

                switch (info.KeyChar)
                {
                    case '+':
                        sonuc = sayiBir + sayiIki;
                        Console.WriteLine(sayiBir + " + " + sayiIki + " =" + sonuc);
                        break;

                    case '-':
                        sonuc = sayiBir - sayiIki;
                        Console.WriteLine(sayiBir + " - " + sayiIki + " =" + sonuc);
                        break;

                    case '*':
                        sonuc = sayiBir * sayiIki;
                        Console.WriteLine(sayiBir + " x " + sayiIki + " =" + sonuc);
                        break;

                    case '/':
                        sonuc = sayiBir / sayiIki;
                        Console.WriteLine(sayiBir + " / " + sayiIki + " =" + sonuc);
                        break;
                }

            Console.Write("Devam için <Enter> tuşuna basın... ");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.Clear();
            goto devam;
             
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize notunu giriniz:");
            int vize = int.Parse(Console.ReadLine());

            Console.WriteLine("Final notunu giriniz:");
            int final= int.Parse(Console.ReadLine());

            double ortalama = 0.4 * vize + 0.6 * final;

            string harfNotu= " ";

            if(ortalama>=90 && ortalama<=100)
            {
                harfNotu = "Harf Araligi: AA - Notu:4,00";
                
            }
            else if (ortalama >= 85 && ortalama <= 89)
            {
                harfNotu = "Harf Araligi: BA - Notu:3,50";
            }
            else if (ortalama >= 80 && ortalama <= 84)
            {
                harfNotu = "Harf Araligi: BB - Notu:3,00";
            }
            else if (ortalama >= 75 && ortalama <= 79)
            {
                harfNotu = "Harf Araligi: CB - Notu:2,50";
            }
            else if (ortalama >= 70 && ortalama <= 74)
            {
                harfNotu = "Harf Araligi: CC - Notu:2,00";
            }
            else if (ortalama >= 65 && ortalama <= 69)
            {
                harfNotu = "Harf Araligi: DC - Notu:1,50";
            }
            else if (ortalama >= 60 && ortalama <= 64)
            {
                harfNotu = "Harf Araligi: DD - Notu:1,00";
            }
            else if (ortalama >= 50 && ortalama <= 59)
            {
                harfNotu = "Harf Araligi: FD - Notu:0,50";
            }
            else  
            {
                harfNotu = "49 alti Harf Araligi: FF - Notu:0,50";
            }  

            if(vize<0||final<0||vize>100||final>100)
            {
                Console.WriteLine("Hatali not girdiniz");
            }
            else
            {
                Console.WriteLine(harfNotu);
            }
            Console.ReadKey();
        }
    }
}

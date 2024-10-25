using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_Girilen_2_Sayinin_Bolumunu_Bulan_CSharp_Kodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Birinci Sayıyı Giriniz: ");
            int Sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            int Sayı2 = Convert.ToInt32(Console.ReadLine());

            if (Sayı2 == 0)
            {
                Console.Write("Bölüm İşleminde Payda Sıfıra Bölünmez");
            }

            else
            {
                int Bölüm = Sayı1 / Sayı2;
                Console.Write("Sonuç: " + Bölüm);
            }

            Console.ReadKey();

        }
    }
}
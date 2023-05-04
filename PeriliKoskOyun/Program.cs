using PeriliKoskOyun;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Yakın zamanda vefat eden zengin bir milyonerin uzak bir aile üyesisin");
            Console.WriteLine("Vefat eden akrabanın bir perili köşkü olduğunu ve onun yalnız yaşadığını biliyorsun.");
            Console.WriteLine("Bu perili köşkte, değerli eşyalar sakladığını biliyorsun.");
            Console.WriteLine("Herkesten önce davranıp, perili köşke doğru yola çıkıyorsun.");
            Console.WriteLine("Ev eski, gıcırtılı ve dökülüyor. Ön kapıdan giriyorsun.");

            Console.WriteLine("\nLütfen isminizi girin:");
            Console.Write("> ");
            string playerName = Console.ReadLine();
            Console.Clear();
            ConsoleKey cevap;
            do
            {
                Console.Clear();
                
                Console.WriteLine("Envanter bilgileri");
                Console.WriteLine("------------------");
                Console.WriteLine("Kutu Anahtarı: " + Esyalar.AnahtarSayisi);
                Console.WriteLine("Kapı Anahtarı: " + Esyalar.KapiAnahtari);
                Console.WriteLine("Sopa: " + Esyalar.SopaSayisi);
                Console.WriteLine("Okunan Not Sayısı: " + Esyalar.NotSayisi);
                Console.WriteLine("Araba Anahtari: " + Esyalar.ArabaAnahtari);
                Console.WriteLine("Araç: " + Esyalar.ArabaSayisi);
                Console.WriteLine("Mücevher: " + Esyalar.DegerliEsyaSayisi);
                Console.WriteLine("------------------");
                Console.WriteLine(playerName + ", nereye gitmek istersin?");
                Console.WriteLine();
                Console.WriteLine("1 - Oturma Odası");
                Console.WriteLine("2 - Mutfak");
                Console.WriteLine("3 - Merdivenler");
                Console.WriteLine("4 - Yatak Odası");
                Console.WriteLine("5 - Kiler");
                Console.WriteLine("6 - Arka Bahçe");
                Console.WriteLine("7 - Garaj");
                cevap = Console.ReadKey().Key;
                Menu.Islemler(cevap);
            } while (cevap != ConsoleKey.D0 && cevap != ConsoleKey.NumPad0);


            Console.ReadKey();
        }
    }
}

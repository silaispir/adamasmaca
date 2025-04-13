using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamasmaca
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Oyuna başlamak için herhangi bi tuşa basın:");
            Console.WriteLine("NOT:Türkçe karakterler yoktur!!");
            Console.ReadLine();
            ArrayList kelimeler = new ArrayList();
            kelimeler.Add("gülden");
            kelimeler.Add("ask");
            kelimeler.Add("masa");
            kelimeler.Add("yasam");
            kelimeler.Add("yazılım");

            Random rnd = new Random();
            string secilenKelime = (string)kelimeler[rnd.Next(kelimeler.Count)];

            char[] tahminEdilen = new char[secilenKelime.Length];
            for (int i = 0; i < tahminEdilen.Length; i++)
            {
                tahminEdilen[i] = '_';
            }

            int kalanHak = 6;
            ArrayList yanlisHarfler = new ArrayList();

            while (kalanHak > 0 && new string(tahminEdilen) != secilenKelime)
            {
                Console.Clear();
                Console.WriteLine("Adam Asmaca Oyunu");
                Console.WriteLine("Kelime: " + string.Join(" ", tahminEdilen));
                Console.WriteLine("Yanlış Harfler: " + string.Join(", ", yanlisHarfler.ToArray()));
                Console.WriteLine("Kalan Hakkın: " + kalanHak);
                Console.Write("Bir harf tahmin et: ");
                string giris = Console.ReadLine().ToLower();
                char tahmin = giris[0];

                if (secilenKelime.Contains(tahmin))
                {
                    for (int i = 0; i < secilenKelime.Length; i++)
                    {
                        if (secilenKelime[i] == tahmin)
                        {
                            tahminEdilen[i] = tahmin;
                        }
                    }
                }
                else
                {
                    if (!yanlisHarfler.Contains(tahmin))
                    {
                        kalanHak--;
                        yanlisHarfler.Add(tahmin);
                    }
                }
            }

            Console.Clear();
            if (new string(tahminEdilen) == secilenKelime)
            {
                Console.WriteLine("Tebrikler! Kelimeyi buldun: " + secilenKelime);
            }
            else
            {
                Console.WriteLine("Kaybettin! Doğru kelime: " + secilenKelime);
            }

            Console.WriteLine("Çıkmak için bir tuşa bas...");
            Console.ReadKey();
        }
    }

    
}


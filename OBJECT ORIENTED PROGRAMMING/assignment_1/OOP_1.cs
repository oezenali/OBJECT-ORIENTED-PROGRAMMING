using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x
{
    class x
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int secim = 0;
            Console.WriteLine("..:: İşlemler ::..");
            Console.WriteLine("1-Matris işlemleri");
            Console.WriteLine("2-String işlemleri");
            Console.WriteLine("3-Çıkış");
            Console.WriteLine("Seçiminiz:");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    new MatrisIslemleri().Menu();
                    break;
                case 2:
                    Console.Clear();
                    new StringIslemleri().Menu();
                    break;
                case 3:
                    Console.WriteLine("Çıkış yapmak");
                    Console.WriteLine("Devam etmek için tıklayınız");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim");
                    Console.WriteLine("Devam etmek için tıklayınız");
                    break;
            }
        }
    }

    internal class StringIslemleri
    {
        private string metin;
        private char karakter;
        public void Menu()
        {

            do
            {
                Console.WriteLine("..:: String İşlemleri ::..");
                Console.Write("İşlem Yapılacak Stringi Giriniz:");
                metin = Console.ReadLine();
                Console.Write("İstenen harf:");
                karakter = Convert.ToChar(Console.ReadLine()[0]);
            } while (metin.Count(x => x == karakter) != 2);

            Console.WriteLine("1-Ara Metni Tersten Yaz");
            Console.WriteLine("2-Ara Metni Tekrarlı Yaz");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine(Tersten());
                    break;
                case 2:
                    Console.WriteLine(Tekrarli());
                    break;
            }

            Console.ReadLine();
        }

        private string Tekrarli()
        {
            string satir = Tersten();
            string sonuc = "";
            for (int i = 0; i < 5; i++)
                sonuc += "\n" + satir;
            return sonuc;

        }

        private string Tersten()
        {
            return new String(metin.Substring(metin.IndexOf(karakter) + 1, metin.LastIndexOf(karakter) - metin.IndexOf(karakter) - 1).Reverse().ToArray());
        }

    }

    class MatrisIslemleri
    {
        private int[,] matris;

        public void Menu()
        {
            Console.WriteLine("Satir sayisini giriniz : ");
            int satir = int.Parse(Console.ReadLine());
            Console.WriteLine("Sutun sayisini giriniz : ");
            int sutun = int.Parse(Console.ReadLine());
            Console.WriteLine("Matris elemanlari");
            matris = new int[satir, sutun];
            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("[{0},{1}] : ", i + 1, j + 1);
                    matris[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Verdiginiz Matris");
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                    Console.Write("\t{0}", matris[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("1-Satir En Buyuk");
            Console.WriteLine("2-Satir Toplam");
            Console.WriteLine("Seçiminiz:");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                int[] buyukler = BuyukBul();
                for (int i = 0; i < buyukler.Length; i++) Console.Write($"{buyukler[i]}\n");
            }
            else if (secim == 2)
            {
                int[] toplamlar = ToplamBul();
                for (int i = 0; i < toplamlar.Length; i++) Console.Write($"{toplamlar[i]}\n");
            }
            else
            {
                Console.WriteLine("Hatalı Seçim");
            }
            Console.WriteLine("Devam etmek için tıklayınız.");
        }

        private int[] ToplamBul()
        {
            List<int> sonuclar = new List<int>();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                int toplam = 0;
                for (int j = 0; j < matris.GetLength(1); j++)
                    toplam += matris[i, j];
                sonuclar.Add(toplam);
            }
            return sonuclar.ToArray();
        }

        private int[] BuyukBul()
        {
            List<int> sonuclar = new List<int>();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                int eb = matris[i, 0];
                for (int j = 1; j < matris.GetLength(1); j++)
                    if (eb < matris[i, j])
                        eb = matris[i, j];
                sonuclar.Add(eb);
            }
            return sonuclar.ToArray();
        }
    }
}
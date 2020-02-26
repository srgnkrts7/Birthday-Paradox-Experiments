using System;

namespace BirthdayParadoxExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("################## İŞLEMLER ARASINDA GECİŞ YAPMAK İÇİN LÜTFEN 'ENTER' TUŞUNU KULLANINIZ! ##################");
            Console.WriteLine("##################      PROGRAM SONLANANA KADAR BU GEÇİŞLER BU ŞEKİLDE OLACAKTIR!        ##################");
            Console.WriteLine();
            int[,] dogumGunleri = new int[31, 12];
            int sayac = 50;
            //50 kişi için yapılan 10 deney için gerekli işlemler ve ortalama yazdırma
            Console.WriteLine("------> 50 KİŞİ İÇİN YAPILAN DENEYLER <------\n");
            int ortalamaCakisma1 = 0;
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(a + 1 + ".DENEY");
                DogumGunuUretme(sayac, dogumGunleri);
                ortalamaCakisma1 += ToplamCakisma(dogumGunleri);
                continue;
            }
            Console.WriteLine("50 KİŞİ İÇİN 10 DENEY SONUCU ORTALAMA ÇAKIŞMA SAYISI:" + (ortalamaCakisma1 / 10));
            Console.WriteLine();
            Console.ReadKey();
            sayac += 50;
            //100 kişi için yapılan 10 deney için gerekli işlemler ve ortalama yazdırma
            Console.WriteLine("------> 100 KİŞİ İÇİN YAPILAN DENEYLER <------\n");
            int ortalamaCakisma2 = 0;
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j + 1 + ".DENEY");
                DogumGunuUretme(sayac, dogumGunleri);
                ortalamaCakisma2 += ToplamCakisma(dogumGunleri);
                continue;
            }
            Console.WriteLine("100 KİŞİ İÇİN 10 DENEY SONUCU ORTALAMA ÇAKIŞMA SAYISI:" + (ortalamaCakisma2 / 10));
            Console.WriteLine();
            Console.ReadKey();
            sayac += 400;
            //500 kişi için yapılan 10 deney için gerekli işlemler ve ortalama yazdırma
            Console.WriteLine("------> 500 KİŞİ İÇİN YAPILAN DENEYLER <------\n");
            int ortalamaCakisma3 = 0;
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k + 1 + ".DENEY");
                DogumGunuUretme(sayac, dogumGunleri);
                ortalamaCakisma3 += ToplamCakisma(dogumGunleri);
                continue;
            }
            Console.WriteLine("500 KİŞİ İÇİN 10 DENEY SONUCU ORTALAMA ÇAKIŞMA SAYISI:" + (ortalamaCakisma3 / 10));
            Console.WriteLine();
            Console.ReadKey();
            sayac += 500;
            //1000 kişi için yapılan için gerekli işlemler ve ortalama yazdırma
            Console.WriteLine("------> 1000 KİŞİ İÇİN YAPILAN DENEYLER <-------\n");
            int ortalamaCakisma4 = 0;
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine(l + 1 + ".DENEY");
                DogumGunuUretme(sayac, dogumGunleri);
                ortalamaCakisma4 += ToplamCakisma(dogumGunleri);
                continue;
            }
            Console.WriteLine("1000 KİŞİ İÇİN 10 DENEY SONUCU ORTALAMA ÇAKIŞMA SAYISI:" + (ortalamaCakisma4 / 10));
            Console.WriteLine();
            Console.ReadKey();
            //50-100 ve 250 kişi için üretilen doğum günü sayılarını hesaplama
            Console.WriteLine("----------> YUKARIDAKİ İŞLEMLERDEN BAĞIMSIZ OLARAK 50-100 ve 250 KİŞİ İÇİN ÜRETİLEN DOĞUM GÜNÜ SAYILARI <----------\n");
            Console.ReadKey();
            Console.WriteLine("50 KİŞİ İÇİN:");
            ToplamUretilenDogumGunu(50);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("100 KİŞİ İÇİN:");
            ToplamUretilenDogumGunu(100);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("250 KİŞİ İÇİN:");
            ToplamUretilenDogumGunu(250);
            Console.ReadKey();
        }
        // Random doğum günlerini ve aylarını bulan metot
        static void DogumGunuUretme(int n, int[,] dogumGunleri)
        {
            Random rnd = new Random();
            MatrisResetleme(dogumGunleri);
            for (int j = 0; j < n; j++)
            {
                int gun;
                int ay = rnd.Next(12);
                if (ay == 0 || ay == 2 || ay == 4 || ay == 6 || ay == 7 || ay == 9 || ay == 11) //31 gün olan aylar
                {
                    gun = rnd.Next(0, 31);
                }
                else if (ay == 3 || ay == 5 || ay == 8 || ay == 10)  //30 gün olan aylar
                {
                    gun = rnd.Next(0, 30);
                }
                else //Şubat ayının 29 çekmesi
                {
                    gun = rnd.Next(0, 29);
                }
                dogumGunleri[gun, ay]++;
            }
            //Bulunan doğum günlerini ekrana tablo halinde döndürme ve toplam cakışma sayısını yazdırma
            Yazdırma(dogumGunleri);
            Console.WriteLine();
            Cakisma(dogumGunleri);
            Console.ReadKey();
        }
        //Cakışmalar da dahil olmak üzere toplam üretilen doğum günü sayısını bulan metot
        static void ToplamUretilenDogumGunu(int n)
        {
            Random rnd = new Random();
            int randomSayac = 0;
            string[] randomlist = new string[n];
            int ay;
            int gun;
            String gunString;
            String ayString;
            String dogumGunu;
            while (randomlist[n - 1] == null) //Random listin son elemanı boş olduğu sürece dönecek
            {
                ay = rnd.Next(12);
                if (ay == 0 || ay == 2 || ay == 4 || ay == 6 || ay == 7 || ay == 9 || ay == 11)
                {
                    gun = rnd.Next(0, 31);

                }
                else if (ay == 3 || ay == 5 || ay == 8 || ay == 10)
                {
                    gun = rnd.Next(0, 30);
                }
                else
                {
                    gun = rnd.Next(0, 29);
                }
                randomSayac++;
                gunString = Convert.ToString(gun); // Günü ve ayı stringe çevirip, string arrayinde birleşik olarak yazdırıp kıyaslama 
                ayString = Convert.ToString(ay);
                dogumGunu = gunString + ayString;
                int i = 0;
                if (randomlist[i] == null) //Listenin boş olması durumu
                {
                    randomlist[i] = dogumGunu;
                }
                else
                {
                    while (randomlist[i] != null) //Elemanları tek tek dolaşma
                    {
                        if (randomlist[i] != dogumGunu) //Elemanla gelen doğum gününü kıyaslama
                            i++;
                        else
                        {   // Gelen elemanın çakışma durumu
                            ay = rnd.Next(12);
                            if (ay == 0 || ay == 2 || ay == 4 || ay == 6 || ay == 7 || ay == 9 || ay == 11)
                            {
                                gun = rnd.Next(0, 31);

                            }
                            else if (ay == 3 || ay == 5 || ay == 8 || ay == 10)
                            {
                                gun = rnd.Next(0, 30);
                            }
                            else
                            {
                                gun = rnd.Next(0, 29);
                            }
                            randomSayac++;
                            gunString = Convert.ToString(gun);
                            ayString = Convert.ToString(ay);
                            dogumGunu = gunString + ayString;
                            i = 0;
                        }
                    }
                    randomlist[i] = dogumGunu;
                }
            }
            Console.WriteLine("ÇAKIŞMALAR DAHİL ÜRETİLEN TOPLAM DOĞUM GÜNÜ SAYISI: " + randomSayac);
        }
        //Her deney sonucu oluşan çakışma sayısını bulan metot
        static void Cakisma(int[,] dogumGunleri)
        {
            int cakisma = 0;
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (dogumGunleri[i, j] > 1)
                    {
                        cakisma += dogumGunleri[i, j] - 1;
                    }
                }
            }
            Console.WriteLine("ÇAKIŞMA SAYISI= " + cakisma + "\n");
        }
        //Her deney sonucu oluşan çakışma sayılarını geri döndürüp 10 deney için toplam çakışma sayısını bulan metot
        static int ToplamCakisma(int[,] dogumGunleri)
        {
            int toplamCakismaSayisi = 0;
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (dogumGunleri[i, j] > 1)
                    {
                        toplamCakismaSayisi += dogumGunleri[i, j] - 1;
                    }
                }
            }
            return toplamCakismaSayisi;
        }
        //Her deney sonrası matrisdeki elemanları sıfırlayan metot
        static void MatrisResetleme(int[,] dogumGunleri)
        {
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    dogumGunleri[i, j] = 0;
                }
            }
        }
        //Tablo halinde bilgileri ekrana yazdıran metot
        static void Yazdırma(int[,] dogumGunleri)
        {
            Console.Write("         ");
            for (int i = 0; i < 31; i++)
            {
                Console.Write((i + 1) + (i < 9 ? "   " : "  "));
            }
            Console.WriteLine();
            string[] aylar = { "Ocak    ", "Şubat   ", "Mart    ", "Nisan   ", "Mayıs   ", "Haziran ", "Temmuz  ", "Ağustos ", "Eylül   ", "Ekim    ", "Kasım   ", "Aralık  " };
            for (int j = 0; j < 12; j++)
            {
                Console.Write(aylar[j] + " ");
                for (int i = 0; i < 31; i++)
                {
                    if (dogumGunleri[i, j] > 9)
                    {
                        Console.Write(dogumGunleri[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(dogumGunleri[i, j] + "   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}                                                                                                       // Sergen KARATAŞ 05150000637
                                                                                                        // Mert GÜLBAHÇE  05150000684

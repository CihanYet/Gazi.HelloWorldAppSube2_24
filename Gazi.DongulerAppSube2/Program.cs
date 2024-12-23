using System.Diagnostics;

namespace Gazi.DongulerAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsiminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere yazılsın?");
            //int tekrar = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= tekrar; i++)
            //{
            //    Console.WriteLine($"{i}-{isim}");
            //}


            //Başlangıç değeri giriniz:5
            //Bitiş değeri giriniz:8
            //5
            //6
            //7





            //Console.WriteLine("Başlangıç değeri giriniz:");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş değeri giriniz:");
            //int bit = int.Parse(Console.ReadLine());
            //Console.WriteLine("1-Tek/2-Çift?");
            //int tekcift = int.Parse(Console.ReadLine());


            ////bas:8
            ////bit:5
            //if (bas > bit)
            //{
            //    int temp = bas;
            //    bas = bit;
            //    bit = temp;
            //}
            //int toplam = 0;
            //int sonuc = (tekcift == 1) ? 1 : 0;
            //for (int i = bas; i <= bit; i++)
            //{
            //    if (i % 2 == sonuc)
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);



            //5-6-7-8
            //int toplam = 0;
            //toplam = toplam + 5;
            //toplam = toplam + 6;
            //top=lam  toplam + 7;
            //toplam = toplam + 8;
            //Console.WriteLine(toplam);


            //Console.WriteLine("Taban değeri giriniz:");
            //int taban = int.Parse(Console.ReadLine());

            //Console.WriteLine("Üs değer giriniz:");
            //int us = int.Parse(Console.ReadLine());

            ////taban:2 üs:3

            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine($"İşlemin sonucu:{sonuc}");

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"İşlemin sonucu:{sonuc}");
            //1-2-3-4-5

            //Console.WriteLine("Sayı Giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 2; i <= sayi / 2; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac == 0 ? "Asal" : "Asal Değil");

            //for (; ; )
            //{

            //}

            //while (true)
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz:");
            //    string user = Console.ReadLine();

            //    Console.WriteLine("Şifre giriniz:");
            //    string pass = Console.ReadLine();

            //    if (user == "admin" && pass == "123")
            //    {
            //        Console.WriteLine("Giriş başarılı");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar deneyiniz..");
            //    }
            //}


            //Sayı giriniz:5
            //Devam etmek istiyormusunuz?e
            //Sayı giriniz:10
            //Devam etmek istiyormusunuz?h
            //Girilen sayıların toplamı:15


            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine("Devam etmek istiyor musunuz?");
            //    char cvp = char.Parse(Console.ReadLine());
            //    if (cvp == 'h')
            //    {
            //        Console.WriteLine($"Sayıların toplamı:{toplam}");
            //        break;
            //    }
            //}

            int toplam = 0;
            char cvp;
            do
            {
                Console.WriteLine("Sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
                Console.WriteLine("Devam etmek istiyor musunuz?E/H");
                cvp = char.Parse(Console.ReadLine());
            } while (cvp == 'e');

            Console.WriteLine($"Sayıların toplamı:{toplam}");

        }
    }
}

//Dongüler: Aynı işi tekrar tekrar yaptırmak için kullanılan yapılardır.
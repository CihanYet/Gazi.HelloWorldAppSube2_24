﻿using System;

namespace Gazi.HelloWorldAppSube2
{
    internal class Program
    {
        static int sayi = 15;
        static void Main(string[] args)
        {
            //Console.WriteLine("Gazi");
            //Console.WriteLine("Üniversitesi");

            //byte a;
            //double d;
            //a = 30;
            //d = 40;

            //byte a = 30;
            //double d = 40;
            //a = 50;

            //Console.WriteLine(a);

            //const int a = 50;

            //byte yas;
            //Console.WriteLine(yas);

            //int sayi = 10;
            //byte number = 10;

            //float sayi = 3.15f;
            //double _sayi = 3.15;
            //decimal __sayi = 3.15m;

            //var sayi = 10.5D;//Implicit (Veri tipi belirlenmeden yapılan tanılamalar
            //byte number = 5;//Explicit (Veri tipinin açık olara belirtildiği tanımlamalar)

            //var sonuc = true;

            string isim = "Ahmet";
            string soyad = "Mehmet";



            Console.ReadKey();
        }
    }
}

//namespace:İçinde classları bulunduran yapılardır.
//Scope(Blok Yapıları): {} parantezleri arasındaki alanlardır.
//Class: İçinde metodları bulunduran yapılardır.(Bu tanım şimdilik yüzeysel olarak yapılmıştır. Daha sonra detaylandırılacaktır)
//Metod: İş yapan kod bloklarına metod denir.
//Main metodu: Console uygulamalarının başlangıç noktasıdır.
//Ctrl+F5: Uygulamayı hata ayıklama modu olmadan başlatır.

//Syntax:Kod yazım kuralları
//1-Açılan her parantez mutlaka kapatılmalıdır.
//2- Scope tanımlamaları sonunda ; kullanılmaz ancak komut satırları sonlarında kullanılır.

//Syntax Hatalarını Nasıl Anlarız?
//1- Hata olan kodun altı kırmızı ile çizilir
//2-Scrool bar'da hata olan yere kırmızı işaretleme yapılır
//3-VS kod editörünün alt çubuğunda Kırmızı renkli X ve yanında hata sayısı görülür.

//Syntax Hatası olan program çalışır mı? Hayır, çünkü program derlenmez.

//IntelliSense: Kod yazarken açılan pencere ile karşımıza çıkan öneriler
//IntelliCode:Yapay zeka destekli kod yazım yardımcısı. Gelen önerileri TAB tuşu ile kabul edebiliriz.

//Solution->Project(s)
//View->Solution Explorer

//Ctrl+K+D: Kod hiyerarşisini düzenlemek için kullanılır.
//Ctrl+K+C: Seçili satırları açıklama satırı haline dönüştürür
//Ctrl+K+U: Açıklama satırını tekrar normal satır haline dönüştürür


//C# -> Derleme -> MS-IL -> .NET Runtime(Derleme) -> 0-1(Binary)

//Microsoft Intermediate Language

//1 Bit = 0 veya 1
//1 byte=8bit
//1 Kilo Byte(KB)=1024 byte
//1 Megabyte(MB) = 1024KB
//1 Gigabyte(GB) = 1024MB
//1 Terabyte(TB) = 1024GB

//sbyte=Signed Byte
//ushort=Unsigned Short
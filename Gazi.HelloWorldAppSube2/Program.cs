using System;

namespace Gazi.HelloWorldAppSube2
{
    internal class Program
    {
        static int sayi = 15;
        static void Main(string[] args)
        {
            #region Veri Tipleri ve Tanımlamaları
            //Console.WriteLine("Gazi");
            //Console.WriteLine("Üniversitesi");

            //const byte a = 20;
            //double d;
            //a = 30;
            //d = 40;
            //Console.Write(a);
            //byte a = 30;
            //double d = 40;
            //a = 50;

            //var number = 10;

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
            #endregion

            #region String Birleştime İşlemleri
            //string isim = "Ahmet";
            //string soyad = "Mehmet";

            //Console.WriteLine("Hoşgeldin, "+ isim + " " + soyad);
            //Console.WriteLine("Hoşgeldin, {0} {1}", isim, soyad);
            //Console.WriteLine($"Hoşgeldin, {isim} {soyad}");
            #endregion

            #region Kullanıcı Etkileşimleri
            //try
            //{
            //    Console.Write("İsminizi Giriniz:");
            //    string name = Console.ReadLine();
            //    Console.Write("Soyadınızı giriniz:");
            //    string surname = Console.ReadLine();
            //    Console.Write("Yaşınızı giriniz:");
            //    byte age = byte.Parse(Console.ReadLine());
            //    Console.WriteLine($"Hoşgeldiniz,\nİsminiz:{name}\nSoyadınız:{surname}\nYaşınız:{age}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Yaşınızı sayı ile giriniz.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası değer giriniz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu...");//Kullanıcıya Göster

            //    Console.WriteLine($"Tarih:{DateTime.Now}\nMessage:{ex.Message}\nStack Trace:{ex.StackTrace}");//Kendimiz için tuttuğumuz loglar.Veritabanı,txt dosyası,email vb olabilir.
            //}

            #endregion

            //double maas = 5000;
            //maas -= 1000;// maas = maas - 1000;
            //Console.WriteLine(maas);

            //int sayi1 = 10;
            //int sayi2 = 20;

            //int sayi3 = ++sayi1;


            // Console.WriteLine(sayi2 % sayi1);

            //Ternary Operator - 3 adet operand alır.
            //string sonuc = sayi1 > sayi2 ? "Sayı 1 büyük" : "Sayı2 büyük veya sayılar eşit";

            #region Tür Dönüşümleri

            //byte sayi = 20;
            //int number = sayi;//Implicit Type Casting

            //checked
            //{
            //    int sayi = 257;
            //    byte number = (byte)sayi;//Explicit Type Casting
            //    Console.WriteLine(number);
            //}

            //string value = "20";
            //string value2 = "30";
            //byte sayi = Convert.ToByte(value);
            //byte sayi2 = byte.Parse(value2);
            //Console.WriteLine(sayi + sayi2);

            //int sayi = 20;//STACK
            //object value = sayi;//STACK->HEAP Boxing
            //int number = (int)value;//Heap->Stack Unboxing 
            #endregion


            //Console.WriteLine("1. sayıyı giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 büyüktür");
            //}
            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("Sayı 2 büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşit");
            //}


            //Console.WriteLine("Hava nasıl?(Güzel/Kötü)");
            //string cevap = Console.ReadLine().ToLower().Trim();

            //if (cevap == "güzel")
            //{
            //    Console.WriteLine("Kaç derece");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece < 15)
            //    {
            //        Console.WriteLine("Hava soğuk labda otur");
            //    }
            //    else if (derece >= 15 && derece <= 35)
            //    {
            //        Console.WriteLine("Dışarı çık");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hava sıcak labda otur.");
            //    }
            //}
            //else if (cevap == "kötü")
            //{
            //    Console.WriteLine("Evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("Sadece Güzel/Kötü cevabı verebilirsiniz.");
            //}

            Console.WriteLine("İşlem seçiniz:\n1-EFT\n2-Havale İşlemleri\n3-İnternet Bankacılığı\n4-Şifre İşlemleri");
            byte cevap = byte.Parse(Console.ReadLine());
            if (cevap == 1)
            {
                Console.WriteLine("EFT işlemleri");
            }
            else if (cevap == 2)
            {
                Console.WriteLine("Havale işlemleri");
            }
            else if (cevap == 3)
            {
                Console.WriteLine("İnternet Bankacılığı işlemleri");
            }
            else if (cevap == 4)
            {
                Console.WriteLine("Şifre işlemleri");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }


            switch (cevap)
            {
                case 1:
                    Console.WriteLine("EFT İşlemleri");
                    break;
                case 2:
                    Console.WriteLine("Havale İşlemleri");
                    break;
                case 3:
                    Console.WriteLine("İnternet Bankacılığı");
                    break;
                case 4:
                    Console.WriteLine("Şifre İşlemleri");
                    break;
                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                    break;
            }

            Console.ReadKey();

            //<15 : Hava soğuk Evde otur
            //15-35 : Dışarı çık
            //>35 Hava sıcak evde otur


            //Dil Seçiniz (TR/EN):TR
            //1-Kare
            //2-Daire
            //3-Üçgen
            //1
            //Kare seçtiniz. Alan/Çevre?
            //Alan
            //Karenin bir kenarının uzunluğunu giriniz:5
            //Karenin alanı:25
        

            Console.WriteLine("Şekil seçiniz:\n1-Kare\n2-Daire\n3-Üçgen");
            byte secim = byte.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Kare seçtiniz. Alan/Çevre?");
                    string hesap = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine("Karenin kenar uzunluğunu giriniz:");
                    int kenar = int.Parse(Console.ReadLine());
                    //if (hesap == "alan")
                    //{
                    //    Console.WriteLine($"Karenin alanı:{kenar * kenar}");
                    //}
                    //else if (hesap == "çevre")
                    //{
                    //    Console.WriteLine($"Karenin çevresi:{4 * kenar}");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Hatalı seçim yaptınız.");
                    //}

                    Console.WriteLine(hesap == "alan" ? $"Karenin alanı:{kenar * kenar}" : $"Karenin Çevresi:{4 * kenar}");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız..");
                    break;
            }


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

//Değer tipleri belleğin STACK bölgesini kullanır
//Referans tipleri HEAP bölgesi kullanır
//HEAP bölgesi stack bölgesine göre daha büyüktür. Dolayısıyla tek seferde birden fazla veri depolayabilir. Örn. Ahmet stringinde 5 tane char vardır.
//Referans tipi değişkenlerde, referanslar STACK bölgesinde, değerler HEAP bölgesinde tutulur. Değere ulaşmak için, o değerin HEAP bölgesindeki adresini bilen referansına ulaşmak gereklidir.

//Metod Parametresi: Metodların işlerini yapabilmek için ihtiyaç dudukları verilerdir. Bir metod hiç parametre istemeyebilir yada birden fazla veri tipinde paramere de kabul edebilir.

//void: Bu geri dönüş tipine sahip metodlar, işlerini yaptıktan sonra geriye bilgi dönmezler.

//C# programlama dili Tip Güvenliği(Type Safety) sağlayan bir dildir.
//Uyumsuz tipler arası veri ataması yapılamaz. Örn. string->byte
//checked blokları: Büyük türden küçük türe yapılan dönüşümlerde hata atarak, veri kaybı ihtimalini önler.
//Debug:Hata yakalama işlemleri. 
//Hata yönetimleri C#'da try-catch ile yapılır

//Ctrl+F5: Start without debugging
//F5: Start Debugging

//1 && 1 = 1
//1 && 0 = 0
//0 && 1 = 0
//0 && 0 = 0

//1 || 1 = 1
//1 || 0 = 1
//0 || 1 = 1
//0 || 0 = 0

//Breakpoint:Programın istenen satırda durdurulup, sonraki satırların adım adım izlenmesine olanak sağlayan DEBUG yöntemidir.

//Case Sensitive: C# programlama dilinde büyüm harfler ile küçük harfler aynı değildir. Büyük/Küçük harf duyarlılığı

//String classının metodlarından bazıları
//ToLower(): Tüm karakterleri küçük harfe çevir
//ToUpper():Tüm karakterleri büyük harfe çevir
//Trim(): String ifadenin başında ve sonunda bulunan boşlukları siler
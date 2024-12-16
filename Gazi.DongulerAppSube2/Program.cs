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





            Console.WriteLine("Başlangıç değeri giriniz:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş değeri giriniz:");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("1-Tek/2-Çift?");
            int tekcift = int.Parse(Console.ReadLine());


            //bas:8
            //bit:5
            if (bas > bit)
            {
                int temp = bas;
                bas = bit;
                bit = temp;
            }
            int toplam = 0;
            int sonuc = (tekcift == 1) ? 1 : 0;
            for (int i = bas; i <= bit; i++)
            {
                if (i % 2 == sonuc)
                {
                    Console.WriteLine(i);
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);







            //5-6-7-8
            //int toplam = 0;
            //toplam = toplam + 5;
            //toplam = toplam + 6;
            //top=lam  toplam + 7;
            //toplam = toplam + 8;
            //Console.WriteLine(toplam);
        }
    }
}

//Dongüler: Aynı işi tekrar tekrar yaptırmak için kullanılan yapılardır.
namespace Gazi.DizilerAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[3];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;           

            //int[] sayilar = { 10, 20, 30 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //Console.WriteLine("Kaç isim kaydetmek istiyorsunuz?");
            //int adet = int.Parse(Console.ReadLine());
            //string[] isimler = new string[adet];
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("İsim Giriniz:");
            //    isimler[i] = Console.ReadLine();
            //}
            ////****Girilen İsimler*****
            //Array.Sort(isimler);
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            int[,] dizi = new int[2, 3];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[0, 2] = 30;
            dizi[1, 0] = 40;
            dizi[1, 1] = 50;
            dizi[1, 2] = 60;

            for (int i = 0; i < 2; i++)//Satır
            {
                for (int j = 0; j < 3; j++)//Sutun
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
//Diziler(Array-Dizi Değişkenler): Bellekte aynı anda birden fazla aynı türde veri tutmak için kullanılır.
//Index: Dizi elemanlarına ulaşmak için kullanılan sayılardır. 0'dan başlar.
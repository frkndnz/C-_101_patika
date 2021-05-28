using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
           //dizi tanımlama 
           string[] renkler = new string [5];

           string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
           int[] dizi ;
           dizi = new int[5];

           // dizilere değer atama ve erişim 

           renkler[0] = "mavi";
           Console.WriteLine(hayvanlar[0]);
           dizi[3] = 10;
           Console.WriteLine(dizi[3]);
           Console.WriteLine(renkler[0]);

            // döngülerle dizi kullanımı
            // klavyeden girilen n tane sayının ortalamasını hesaplayan program 
            Console.WriteLine("lütfen dizinin eleman sayısını giriniz :");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("lütfen {0}. sayıyı giriniz :",i+1);
                sayıdizisi[i]=int.Parse(Console.ReadLine());
            }
                int toplam =0;
            foreach (var sayı in sayıdizisi)
            {
                toplam +=sayı;
            }
            Console.WriteLine("ortalama="+ toplam/diziuzunlugu);





        }
    }
}

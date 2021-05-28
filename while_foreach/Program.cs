using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           // while
           // 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesapla konsola yazdır
        //     Console.WriteLine("lütfen bir sayı giriniz :");
        //    int sayı = int.Parse(Console.ReadLine());
        //    int sayac = 1;
        //    int toplam=0;
        //    while (sayac <= sayı)
        //    {
        //        toplam += sayac;
        //        sayac ++;
        //    }
        //    Console.WriteLine(toplam/sayı);


        // ***** a dan z ye kadar olan tüm harfleri konsola yazdır

            // char character = 'a';
            // while (character< 'z')
            // {
            //     Console.WriteLine(character);
            //     character ++;
            // } 

            Console.WriteLine("-----foreach ------");
            string[] arabalar = {"bmw","ford","toyota","nissan"} ;

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}

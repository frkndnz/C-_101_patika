using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır
            // Console.Write("lütfen bir sayı giriniz");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 1; i <=sayac; i++)
            // {
            //     if(i%2 == 1)
            //         Console.WriteLine(i);
            // }

            // int tektoplam=0;
            // int çifttoplam=0;
            // for (int i = 0; i <= 1000; i++)
            //  {
            //   if(i%2==1)
            //     tektoplam +=i;
            //   else
            //     çifttoplam +=i;

            //  }
            // Console.WriteLine("tektoplam= "+tektoplam+"çifttoplam= "+çifttoplam);

            // break and continue
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}

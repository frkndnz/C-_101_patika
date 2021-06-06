using System;

namespace hazır_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // tarih saat
            Console.WriteLine(DateTime.Now.Date); // gün ay yıl
            Console.WriteLine(DateTime.Now.Day); //  gün
            Console.WriteLine(DateTime.Now.Month); // ay
            Console.WriteLine(DateTime.Now.Year); // yıl
            Console.WriteLine(DateTime.Now.Hour); // saat
            Console.WriteLine(DateTime.Now.Minute); // dakika
            Console.WriteLine(DateTime.Now.Second); // saniye


            Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın hangi günündeyim
            Console.WriteLine(DateTime.Now.DayOfYear); // yılın hangi günündeyim

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(4));
            Console.WriteLine(DateTime.Now.AddSeconds(40));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddMilliseconds(45));

            // datetime format 

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("---------Math Kütüphanesi-------");
            // math kütüphanesi

            Console.WriteLine(Math.Abs(-1)); //mutlak alır
            Console.WriteLine(Math.Sin(20));
            Console.WriteLine(Math.Cos(45));
            Console.WriteLine(Math.Tan(60));
            
            Console.WriteLine(Math.Ceiling(22.3)); // 22.3 den büyük en büyük tam sayı =23
            Console.WriteLine(Math.Round(22.3)); // hangi tamsayıya yakınsa=22
            Console.WriteLine(Math.Round(22.7)); // =23     
            Console.WriteLine(Math.Floor(22.7)); // 22.7 den küçük en yakın tamsayı

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6)); 
            Console.WriteLine(Math.Pow(3,4)); // 3^4 verir
            Console.WriteLine(Math.Sqrt(9)); // kök alır
            Console.WriteLine(Math.Log(9)); // 9 'un e tabanındaki karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı 


        }   
    }
}

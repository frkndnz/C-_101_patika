using System;

namespace hata_yonetımı
{
    class Program
    {
        static void Main(string[] args)
        {
           
          try
          {
                // int a =int.Parse(null);
              //int a = int.Parse("test");
              int ab = int.Parse("-2000000000000");

          }
          catch(ArgumentNullException ex)
          {
              Console.WriteLine("boş değer girdiniz");
              Console.WriteLine(ex);
          }
          catch (FormatException ex)
          {
              
              Console.WriteLine("veri tipi uygun değil");
              Console.WriteLine(ex);
          }
          catch(OverflowException ex)
          {
              Console.WriteLine("çok küçük yada çok büyük değer girdiniz");
              Console.WriteLine(ex);
          }
          finally
          {
              Console.WriteLine("işlem tamamlandı");
          }

        }
    }
}

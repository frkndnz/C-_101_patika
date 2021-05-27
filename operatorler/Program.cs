using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =3;
            int y =3;
            y=y+2;
            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal operatörler
            Console.WriteLine("----------Mantıksal Operatörler-------------");
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("perfect");

            if(isSuccess || isCompleted)
            Console.WriteLine("Great");

            if(isSuccess && !isCompleted)
            Console.WriteLine("fine");

            //ilişkisel operatörler
            Console.WriteLine("-------İlişkisel Operatörler--------------");
            int a = 3 ;
            int b = 4 ;
            bool sonuc = a<b ;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler
            Console.WriteLine("-----Aritmetik Operatörler-------");

            int sayı1 = 3;
            int sayı2 = 6;
            int sonuc1 = sayı1/sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1 + sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1 * sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1++;
            Console.WriteLine(sonuc1);

            // % mod almak için kalanı ifade eder
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

            




























            
            


            

















        }
    }
}

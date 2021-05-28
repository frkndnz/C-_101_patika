using System;

namespace tıp_donusumlerı
{
    class Program
    {
        static void Main(string[] args)
    {  
        // implicit conversion (bilinçsiz dönüşüm)

        byte a = 5 ;
        sbyte b = 30;
        short c= 10;

        int d = a+b+c;
        Console.WriteLine(d);
        long h = d ;
        Console.WriteLine(h);
        float i = h;
        Console.WriteLine(i);
        string e = "furkan";
        char f ='k';
        object g = e+f+b;
        Console.WriteLine(g);

        // explicit conversion (bilinçli dönüşüm) c# ın yapamadığı dönüşümler
        Console.WriteLine("***explicit_conversion****");
        int x=4;
        byte y =(byte)x;
        Console.WriteLine("y :"+y);
        
        int z =100;
        byte t =(byte)z;
        Console.WriteLine("t :"+t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v :"+v);

        // *** ToString metodu *****

        Console.WriteLine("****ToString_Metodu****");

        int xx = 6;
        string yy= xx.ToString();
        Console.WriteLine("yy :"+yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz :"+zz);

        // System.Convert 
        Console.WriteLine("****System.Convert sınıfı*****");
        string s1 = "10",s2="20";
        int sayı1,sayı2;
        int toplam;

        sayı1= Convert.ToInt32(s1);
        sayı2= Convert.ToInt32(s2);
        toplam=sayı1+sayı2;
        Console.WriteLine("toplam = "+toplam);

        // Parse 
        Console.WriteLine("****Parse*******");
        ParseMethod();




      }
        public static void ParseMethod()
        {
            string metin1 ="10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1= Int32.Parse(metin1);
            Console.WriteLine("rakam1="+rakam1);
            double1=Double.Parse(metin2);
            Console.WriteLine("double1 ="+double1);
        }

      
      
    }
}

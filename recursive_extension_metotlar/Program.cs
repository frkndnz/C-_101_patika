using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // rekürsif -- özyinelemeli (kendi kendini çağıran fonksiyonlar)
            //3^4=3*3*3*3
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
            }
            Console.WriteLine(result);
            islemler ornek = new islemler();
            int sonuc=ornek.Expo(3,4);
            Console.WriteLine(sonuc);

            // extension metotlar
            string ifade = "furkan  deniz  ankara";
            bool sonuc1=ifade.boşluk_kontrol();
            Console.WriteLine(sonuc);
            if(sonuc1)
            {
                Console.WriteLine(ifade.boşlukları_sil());
            }
            Console.WriteLine(ifade.büyük_harf_yap());
            Console.WriteLine(ifade.küçük_harf_yap());

            int[] dizi = {9,3,6,2,1,5,0};
            dizi.dizi_sırala();
            dizi.Ekrana_yazdır();
            int sayı=5;
            Console.WriteLine(sayı.çift_sayımı());
            Console.WriteLine("furkan".GetFirstCharacter());


        }
    }
    public class islemler
    {
        public int Expo(int sayı,int üs)
        {
            if(üs<2)
                return sayı; 
           return Expo(sayı,üs-1)*sayı;
        }
    }
    public static class extension
    {
        public static bool boşluk_kontrol(this string param)
        {
            return param.Contains(" ");
        }

        public static string boşlukları_sil(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);

        }
        public static string büyük_harf_yap(this string param)
        {
            return param.ToUpper();
        }

        public static string küçük_harf_yap(this string param)
        {
            return param.ToLower();
        }

        public static int[] dizi_sırala(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void Ekrana_yazdır(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool çift_sayımı(this int param)
        {
            return param %2 ==0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }

    }

}

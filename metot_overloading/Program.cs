using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayı ="999";
            bool sonuc =int.TryParse(sayı,out int outsayı);
            if(sonuc)
            {
                Console.WriteLine("başarılı!");
                Console.WriteLine(outsayı);
            }
            else {
                Console.WriteLine("başarısız..");
            }
            metotlar instance = new metotlar();
            instance.topla(4,5,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);

            // metot aşırı yükleme -- overloading
            int ifade = 888;
            instance.ekranayazdır(ifade);
            instance.ekranayazdır("furkan","deniz");
            instance.ekranayazdır("deniz");

        }
    }
    class metotlar
    {
        public void topla(int a ,int b,out int toplam)
        {
            toplam=a+b;
        }

        public void ekranayazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdır(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdır(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2); 
        }
    }
}

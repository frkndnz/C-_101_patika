using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_donustipi  metot_adı(parametreListesi/arguman)
            //{
                //// komutlar;
                // return; 

            //}
            int a =2;
            int b =3;
            Console.WriteLine(a+b);
            int sonuc = topla(a,b);   
            Console.WriteLine(sonuc);

            metotlar örnek = new metotlar();
            örnek.Yazdır(Convert.ToString(sonuc));

            int sonuc2= örnek.arttırVetopla(ref a,ref b);
            örnek.Yazdır(Convert.ToString(sonuc2));
            örnek.Yazdır(Convert.ToString(a+b));        
        }

           static int topla(int deger1,int deger2)
           {
                return(deger1+deger2);
           }
           
    }
    class metotlar
    {
             public void Yazdır(string veri)
            {
                 Console.WriteLine(veri);
            }
            public int arttırVetopla(ref int deger1,ref int deger2)
            {
                deger1+=1;
                deger2+=1;
                return deger1+deger2;
            }
    }
}

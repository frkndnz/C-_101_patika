using System;
using System.Collections.Generic;

namespace generıc_lıst
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T  --> object türündedir.
            
            List<int> sayılistesi = new List<int>{} ;
            List<string> renklistesi = new List<string>{} ;

            sayılistesi.Add(11);
            sayılistesi.Add(24);
            sayılistesi.Add(35);
            sayılistesi.Add(99);
            sayılistesi.Add(10);
            sayılistesi.Add(17);

            renklistesi.Add("Kırmızı");
            renklistesi.Add("Mavi");
            renklistesi.Add("Sarı");
            renklistesi.Add("Yeşil");
            renklistesi.Add("Mor");

            //Count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayılistesi.Count);

            // foreach ve List.ForEach ile elemanlara erişim.
            foreach (var sayı in sayılistesi)
            {
                Console.WriteLine(sayı);
            }
            foreach (var renk in renklistesi)
            {
                Console.WriteLine(renk);
            }
            sayılistesi.ForEach(sayi=> Console.WriteLine(sayi)); // pratik foreach yazımı ***_***
            renklistesi.ForEach(renk=> Console.WriteLine(renk));

            // Listeden eleman çıkarma 
            sayılistesi.Remove(35);
            renklistesi.Remove("Yeşil");

            sayılistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));            

            sayılistesi.RemoveAt(0);
            renklistesi.RemoveAt(1);

            sayılistesi.ForEach(sayi=> Console.WriteLine(sayi));
            renklistesi.ForEach(renk=> Console.WriteLine(renk));

            // Liste içerisinde arama
            if(sayılistesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu"); 

            // eleman ile index e erişme

            Console.WriteLine(renklistesi.BinarySearch("Sarı"));

            // diziyi List'e çevirme

            string[] hayvanlar = {"kedi","köpek","kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi nasıl temizleriz ?
            hayvanListesi.Clear();

            // List içerisinde nesne tutmak istiyorsam
            List<kullanıcılar> kullanıcıListesi = new List<kullanıcılar>();

            kullanıcılar kullanıcı1 = new kullanıcılar();
            kullanıcı1.Isim="Furkan";
            kullanıcı1.Soyisim="Deniz";
            kullanıcı1.Yas=25;
            
            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı2.Isim="Eylül";
            kullanıcı2.Soyisim="Aydemir";
            kullanıcı2.Yas=24;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<kullanıcılar> yeniListe = new List<kullanıcılar>();

            yeniListe.Add(new kullanıcılar(){
                Isim="Arda",
                Soyisim="Deniz",
                Yas=14                
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("kullanıcı adı : "+ kullanıcı.Isim);
                Console.WriteLine("kullanıcı soyisim : "+ kullanıcı.Soyisim);
                Console.WriteLine("kullanıcı yaşı : "+kullanıcı.Yas);
            }
            yeniListe.Clear(); 
        }
    }

    public class kullanıcılar {
        private string isim;
        private string soyisim ;
        private int yas;

        public string Isim{get=>isim ; set=> isim=value; }
        public string Soyisim{get=>soyisim ; set=> soyisim=value;}
        public int Yas{get=>yas ; set=> yas=value; }

    }
}

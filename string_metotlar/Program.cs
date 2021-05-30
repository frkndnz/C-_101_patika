using System;

namespace string_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "dersimiz CSharp,hoşgeldiniz...!";
            string degisken2= "CSharp";
            //length
            Console.WriteLine(degisken.Length);
            
            //toupper ** toupper
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // concat

            Console.WriteLine(string.Concat(degisken,"merhaba."));

            //compare compareto
            Console.WriteLine(degisken.CompareTo(degisken2)); // 1,0,-1 (büyükse 1 eşitse 0 küçükse -1)
            Console.WriteLine(string.Compare(degisken,degisken2,true));

            // contains
            Console.WriteLine(degisken.Contains(degisken2)); // içinde varsa true döner
            Console.WriteLine(degisken.EndsWith("hoşgeldiniz...!")); // ne ile bitiyor doğruyse true
            Console.WriteLine(degisken.StartsWith("dersimiz")); // ne ile başlıyor doğru ise true


            //  Indexof

            Console.WriteLine(degisken.IndexOf("CS")); // C harfini bulduğu zaman olduğu index i döner
            Console.WriteLine(degisken.IndexOf("dersimiz")); 
            Console.WriteLine(degisken.IndexOf("furkan")); // içerisinde yoksa -1 döner

            // Insert

            Console.WriteLine(degisken.Insert(0,"merhaba")); // istediğin index ten başlayarak kelimeyi ekle

            // lastindexof
            Console.WriteLine(degisken.LastIndexOf("i"));   // i harfinin geçtiği son indexi getir
            
            //padleft padright // s
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'*')+degisken2);

            // Remove
            Console.WriteLine(degisken.Remove(10)); // 10.indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5,3)); // 5.indexten sonra 3 index sil
            Console.WriteLine(degisken.Remove(0,1)); // 0.indexten itibaren 1 index sil

            // replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]); // boşluklara göre ayır ve dizinin 1.elemanını getir

            //substring

            Console.WriteLine(degisken.Substring(4)); // 4.indexten başlayarak getir
            Console.WriteLine(degisken.Substring(6,4)); // 6. indexten başlayarak 4 index getir









        }
    }
}

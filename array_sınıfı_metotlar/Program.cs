using System;

namespace array_sınıfı_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayıdizisi = {23,66,3,88,15,7,25,45};
            Console.WriteLine("-------sırasız dizi------");
            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }
            Console.WriteLine("******sıralı dizi*******");
            Array.Sort(sayıdizisi);
            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }

            //clear
            Console.WriteLine("******array clear *****");
            // sayıdizisi elemanlarını kullanarak 2. indexten itibaren 2 tane indexi sıfırlar
            Array.Clear(sayıdizisi,2,2);
            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }
            Console.WriteLine("--------reverse işlemi------");
            // reverse 
            Array.Reverse(sayıdizisi);
            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }
            // indexof 
            Console.WriteLine("-------array ındexof -------");
            Array.IndexOf(sayıdizisi,66);
            Console.WriteLine(Array.IndexOf(sayıdizisi,66));

            // resize (yeniden boyutlandırma)
            Console.WriteLine("*****resize*******");
            Array.Resize<int>(ref sayıdizisi,9);
            sayıdizisi[8] = 99;
            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }



            
            














        }
    }
}

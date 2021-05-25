using System;

namespace console_programmıng
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adınız: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba "+name+" "+surname);
        }
    }
}

using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger =2;
            
            
            String degısken = " ";
            byte a = 5; // 1 byte yer kaplar 0-255
            sbyte ab =5; // 1 byte 
           
            short c= 2; // 2 byte 
            ushort a3 =3; // 2 byte

            Int16 i16=2; //2 byte
            Int32 i32=2; //4 byte
            int i =1; // 2 byte
            Int64 i64=2; // 8byte

            uint ui=2 ; //4byte
            long l =2; //8byte
            ulong ul =3; //8byte
            
            // Reel sayılar ;

            float f =5 ;// 4 byte
            double db =2; // 8byte
            decimal d =4; // 16 byte
            
            char ch = '2' ; // 2 byte
            string str= " furkan " ; // sınırsızdır
            bool bl  = true;
            bool bl1 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt); 

            object o1 ="x";
            object o2 = 'y';
            object o3 = 2;
            object o4 = 4.5;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "furkandeniz";
            string ad = "furkan";
            string soyad= "deniz";
            string tamisim= ad+" "+soyad;

            // integer tanımlama şekilleri

            int integer1 = 5 ;
            int integer2 = 6 ;
            int integer3 = integer1*integer2;


            //bolean

            bool bool1 = 10<2;

            // değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20+int20.ToString();
            Console.WriteLine(yenideger);


            int intsay= Convert.ToInt32(str20)+int20;
            Console.WriteLine(intsay);
            



            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);




















































        }
    }
}

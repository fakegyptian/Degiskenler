using Microsoft.VisualBasic;
using System;

namespace Degisken
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World");

            byte b = 5;     //1 byte
            sbyte c = 5;    // 2 byte
            short s = 5;    // 2 byte
            ushort us = 5;  //2 byte
            Int16 i16 = 5;  //  2 byte
            int i = 5;      // 4 byte
            Int32 i32 = 5;  // 4 byte
            Int64 i64 = 5;  //8 byte
            uint ui = 2;    // 4 byte
            long l = 2;     // 8 byte
            ulong ul = 2;   // 8 byte
            float f = 2;    // 4 byte
            double d = 2;   // 8 byte
            decimal de = 5; // 16 byte
            char ch = '2';   // 2 byte
            string str = "Gunay"; // Sınırsız
            bool b1=true; //
            bool b2=false; //

          

           

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 5.1;

            // String ifadeler

            string str1 = string.Empty;
            str1 = "Günay Efecan";
            string ad = "Günay";
            string soyad = "Efecan";
            string tamisim = ad + "" + soyad ;

            // Int tanımlama işlemleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10 < 2;

            // Değişken dönüşümleri

            string str11 = "11";
            int int11 = 11;
            string YeniDeger = str11 + int11.ToString();
            Console.WriteLine(YeniDeger); // Çıktısı 1111

            int int12 = (int)(int11 + Convert.ToInt64(str11));

            int int13 = int11 + int.Parse(str11);

            Console.WriteLine(int12);    // Çıktısı 22
            Console.WriteLine(int13);     // Çıktısı 22
            //date time
            string date = DateTime.Now.ToString("dd.MM.yyyy");

            Console.WriteLine(date);

            //hour
            string saat = DateTime.Now.ToString("HH.mm");

            Console.WriteLine(saat);

            






        }
    

    }
        
        
}


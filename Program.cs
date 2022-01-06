using System;

namespace Console_Programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Giriniz");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz");
            string Soyad = Console.ReadLine();

            Console.Write("Merhaba " + name +" "+ Soyad);

        }
    }
}


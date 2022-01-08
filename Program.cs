using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 2222222;


            DateTime dt=DateTime.Now;

            System.Console.WriteLine(sayi +" "+dt);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd");
            System.Console.WriteLine(datetime1);

            string datetime2 =DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(datetime2);

        }
    }
}

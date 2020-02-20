using PaulsBoutique.HashCode.Helpers;
using PaulsBoutique.HashCode.Models;
using System;
using System.IO;

namespace PaulsBoutique.HashCode
{
    class Program
    {
        static string path = @"C:\git\C2C-TOM";

        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Kies je bestand");

            var files = Directory.GetFiles(path);

            for (var i = 0; i < files.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + Path.GetFileName(files[i]));
            }

            var chosenIndex = int.Parse(Console.ReadKey().KeyChar.ToString()) - 1;

            Console.Clear();

            Console.WriteLine("Gekozen bestand:");

            Console.WriteLine(Path.GetFileName(files[chosenIndex]));

            var boutique = Paul.CreateBoutique(files[chosenIndex]);

            // For file 1
            switch (chosenIndex)
            {
                case 1:
                    FileOne(boutique);
                    break;
                case 2:
                    FileTwo(boutique);
                    break;
            }
        }

        private static void FileOne(Boutique boutique)
        {
            var bestBurger = boutique.GetBestBurger();

        }

        private static void FileTwo(Boutique boutique)
        {
            throw new NotImplementedException();
        }

        private static void Nothing()
        {
            throw new NotImplementedException();
        }

    }
}

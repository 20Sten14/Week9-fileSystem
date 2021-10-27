using System;
using System.IO;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishList";
            string userfile = "Wishlist";
            string Fullfilepath = @$"{rootDirectory}\{userfile}.txt";

            string[] dataFromFile = File.ReadAllLines(Fullfilepath);

            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
        }
    }
}

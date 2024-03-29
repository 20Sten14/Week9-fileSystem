﻿using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishList";
            string userfile = "Wishlist";
            string Fullfilepath = @$"{rootDirectory}\{userfile}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(Fullfilepath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"{userfile} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{rootDirectory} dose not exist.");
                Directory.CreateDirectory(rootDirectory);
                Console.WriteLine($"{rootDirectory} has been created");
                File.Create(Fullfilepath);
                Console.WriteLine($" {userfile}, txt has been created in {rootDirectory}");
            }
            else
            {
                File.Create(Fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootDirectory}.");
            }
        }
    }
}

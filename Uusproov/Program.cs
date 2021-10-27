using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\julia.voronetskaja\samples";

            Console.WriteLine("Enter directory name:");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exists.");
                Console.WriteLine("Would you like to create a file? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter file name:");
                    string userFile = Console.ReadLine() + ".txt";
                    string userFileFullPath = @$"{newDirectoryFullPath}\{userFile}";
                    File.Create(userFileFullPath);
                }
                else
                {
                    Console.WriteLine("Take care!");
                }

            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created.");
            }



        }
    }
}
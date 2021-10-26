using System;
using System.IO;

namespace fileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("enter directory name");
            string userfolder = Console.ReadLine();

            string newdirectoryfullpath = @$"{rootDirectory}\{userfolder}";

            bool directoryexists = Directory.Exists(newdirectoryfullpath);

            if(directoryexists)
            {
                Console.WriteLine($"{userfolder} exists.");
                Console.WriteLine("Would you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if (userInput == 'Y');
                {
                    Console.WriteLine("Enter file name:");
                    string userfile = Console.ReadLine() + " .txt";
                    string userFilefullpath = $@"{newdirectoryfullpath}\ {userfile}";
                    File.Create(userFilefullpath);
                }

            }
            

            else
            {
                Directory.CreateDirectory(newdirectoryfullpath);
                Console.WriteLine($"Directory {userfolder} has been created");
            }

            
        }
    }
}

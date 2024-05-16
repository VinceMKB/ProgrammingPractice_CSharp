using System;
using System.IO;

namespace FileHandling
{
    public class Solution
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string file = @"D:\ProgrammingPractice_CSharp\FileHandling\file.txt"; // Use @ to avoid needing to escape backslashes
            Console.WriteLine("Reading File using File.ReadAllText()");

            // Read the entire file at once
            if(File.Exists(file))
            {
                string textFromFile = File.ReadAllText(file);
                Console.WriteLine(textFromFile);
            }

            Console.WriteLine();
            Console.WriteLine("Reading File using File.ReadAllLines()");

            // Read a text file line by line
            if(File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);

                foreach(string ln in lines)
                {
                    Console.WriteLine(ln);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Reading File using Stream Reader");

            // By using StreamReader
            if(File.Exists(file))
            {
                using (StreamReader Textfile = new StreamReader(file)) // Using statement ensures the StreamReader is correctly disposed after use
                {
                    string line;

                    while((line = Textfile.ReadLine())!= null) // Corrected to use ReadLine() instead of ReadAllLines()
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.ReadKey();
            }
            Console.WriteLine();
        }
    }
}

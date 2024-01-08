using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class doAppFiles
    {
        public doAppFiles()
        {
            // Demonstrate working with text files

            // Example 1: Writing to a text file
            string filePath = "example.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, this is a sample text file.");
                writer.WriteLine("This is the second line.");
            }

            Console.WriteLine($"Text written to {filePath}");

            // Example 2: Reading from a text file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine($"Content of {filePath}:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Example 3: Appending to a text file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("This line is appended.");
            }

            Console.WriteLine($"Text appended to {filePath}");

            // Example 4: Reading again after appending
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine($"Updated content of {filePath}:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Example 5: Deleting the text file
            File.Delete(filePath);
            Console.WriteLine($"{filePath} deleted.");
        }
    }
}

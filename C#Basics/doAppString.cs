using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class doAppString
    {
        public doAppString()
        {
            // Demonstrate working with text

            // Example 1: Concatenating strings
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name: {fullName}");

            // Example 2: String interpolation
            int age = 30;
            string info = $"Name: {fullName}, Age: {age}";
            Console.WriteLine(info);

            // Example 3: String methods
            string text = "   Hello, World!   ";
            Console.WriteLine($"Original Text: '{text}'");

            // Trim leading and trailing whitespaces
            string trimmedText = text.Trim();
            Console.WriteLine($"Trimmed Text: '{trimmedText}'");

            // Convert to uppercase
            string upperCaseText = text.ToUpper();
            Console.WriteLine($"Uppercase Text: '{upperCaseText}'");

            // Replace "Hello" with "Hi"
            string replacedText = text.Replace("Hello", "Hi");
            Console.WriteLine($"Replaced Text: '{replacedText}'");

            // Example 4: String comparisons
            string str1 = "apple";
            string str2 = "Apple";

            // Case-sensitive comparison
            bool caseSensitiveComparison = str1.Equals(str2);
            Console.WriteLine($"Case-Sensitive Comparison: {caseSensitiveComparison}");

            // Case-insensitive comparison
            bool caseInsensitiveComparison = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Case-Insensitive Comparison: {caseInsensitiveComparison}");

            // Example 5: Substring
            string substring = text.Substring(7, 5);
            Console.WriteLine($"Substring: '{substring}'");

            // Example 6: Splitting a string
            string csvData = "John,Doe,30";
            string[] splitData = csvData.Split(',');
            Console.WriteLine($"CSV Data: {string.Join(", ", splitData)}");
        }
    
    }
}

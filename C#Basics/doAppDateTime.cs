using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class doAppDateTime
    {
        public doAppDateTime()
        {
            // Demonstrate date handling

            // Example 1: Getting the current date and time
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {currentDateAndTime}");

            // Example 2: Formatting a date
            string formattedDate = currentDateAndTime.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"Formatted Date: {formattedDate}");

            // Example 3: Adding days to a date
            DateTime futureDate = currentDateAndTime.AddDays(10);
            Console.WriteLine($"Date 10 days from now: {futureDate}");

            // Example 4: Subtracting days from a date
            DateTime pastDate = currentDateAndTime.AddDays(-5);
            Console.WriteLine($"Date 5 days ago: {pastDate}");

            // Example 5: Calculating the difference between two dates
            TimeSpan dateDifference = futureDate - pastDate;
            Console.WriteLine($"Difference between dates: {dateDifference.Days} days");

            // Example 6: Parsing a date from a string
            string dateString = "2022-12-31";
            if (DateTime.TryParse(dateString, out DateTime parsedDate))
            {
                Console.WriteLine($"Parsed Date: {parsedDate}");
            }
            else
            {
                Console.WriteLine("Invalid date format");
            }
        }
    }
}

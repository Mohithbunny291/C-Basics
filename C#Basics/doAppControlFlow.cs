using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class doAppControlFlow
    {
        public doAppControlFlow()
        {
                // Demonstrate control flow

                // Example 1: if-else statement
                int number = 10;
                if (number > 0)
                {
                    Console.WriteLine("Number is positive.");
                }
                else
                {
                    Console.WriteLine("Number is non-positive.");
                }

                // Example 2: switch statement
                int dayOfWeek = 3;
                switch (dayOfWeek)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    default:
                        Console.WriteLine("Other day");
                        break;
                }

                // Example 3: for loop
                Console.Write("Numbers from 1 to 5: ");
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                // Example 4: while loop
                Console.Write("Countdown from 5 to 1: ");
                int countdown = 5;
                while (countdown > 0)
                {
                    Console.Write(countdown + " ");
                    countdown--;
                }
                Console.WriteLine();

                // Example 5: do-while loop
                Console.Write("Enter a positive number: ");
                int userInput;
                do
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                } while (userInput <= 0);

                Console.WriteLine($"You entered a positive number: {userInput}");
          
        }
    }
}

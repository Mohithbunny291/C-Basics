using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class doAppPrimitive
    {
        public doAppPrimitive()
        {
            // Use arrays to declare variables of primitive types and execute expressions

            // Example with int array
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum of integers: " + SumArray(intArray));

            // Example with double array
            double[] doubleArray = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 };
            Console.WriteLine("Average of doubles: " + CalculateAverage(doubleArray));

            // Example with char array
            char[] charArray = new char[] { 'A', 'B', 'C', 'D', 'E' };
            Console.WriteLine("Concatenated string of chars: " + ConcatenateChars(charArray));
        }

        int SumArray(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        double CalculateAverage(double[] array)
        {
            double sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum / array.Length;
        }

        string ConcatenateChars(char[] array)
        {
            return String.Join(" ", array);
            // or return new string(array);
        }
    }
}

﻿using System;
using System.Threading;

namespace MethodTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declare Variables
            int x, y;

            // Call Method
            x = GetValidInteger();
            y = GetValidInteger();

            // Process
            int result = x * y;
            Console.WriteLine(result);

            // Call PrintNumbers Method
            PrintNumbers(1000);
        }

        // Method to Return Integer
        public static int GetValidInteger()
        {
            int input;

            Console.WriteLine("Please Enter an Integer: ");

            // Validation
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("That is Not an Integer!  Please Enter an Integer:  ");
            }

            return input;  // return input to the caller method
        }

        public static void PrintNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(3000);
            }
        }
    }
}

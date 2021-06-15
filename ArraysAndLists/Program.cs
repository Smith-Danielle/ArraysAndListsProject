using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i + 1;
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            // Or

            /*int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int items in numbers)
            {
                Console.WriteLine(items);
            }*/


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            Console.WriteLine("Enter 10 numbers and I will list them as evens or odds");

            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Here are your even numbers");

            foreach (int evenItems in evens)
            {
                Console.WriteLine(evenItems);
            }

            Console.WriteLine("Here are your odd numbers");

            foreach (int oddItems in odds)
            {
                Console.WriteLine(oddItems);
            }
        }
    }
}

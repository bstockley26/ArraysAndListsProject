﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10


            /* Create a list of type int
             * Name the list "evens"
             */


            /* Create another list of type int
             * Name the list "odds"
             */


            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */



            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */


            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = new List<int>();
            var odds = new List<int>();

            foreach (int num in numbers)
            {
                int i = num % 2;
                

                bool evenOrOdd = i > 0;

                if (evenOrOdd==true)
                {
                    odds.Add(num);
                }
                else
                {
                    evens.Add(num);
                }
            }
            Console.WriteLine("evens:");
            foreach (int num in evens)
            {

                Console.WriteLine(num);
            }
            Console.WriteLine("odds:");
            for (int i=1; i<10;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

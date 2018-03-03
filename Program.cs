using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            Problem1_Multiples_Of_3_And_5();

        }

        private static void Problem1_Multiples_Of_3_And_5()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5,
            //we get 3, 5, 6 and 9.The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            int totalOfAllMultiples = 0;
            int numToTest = 1;
            HashSet<int> listOfMultiples = new HashSet<int>();
            for (int i = 1; i < 1000; i++)
            {

                numToTest = i;
                bool multipleOfThree = (numToTest %= 3) == 0;
                numToTest = i;
                bool multipleOfFive = (numToTest %= 5) == 0;
                
                if (multipleOfThree)
                {
                    listOfMultiples.Add(i);   
                }

                if (multipleOfFive)
                {
                    listOfMultiples.Add(i);
                }

                if (multipleOfFive || multipleOfThree)
                {
                    totalOfAllMultiples += i;
                }
            }
            foreach (int multiple in listOfMultiples)
            {
                Console.WriteLine("Multiple of 3 or 5: " + multiple.ToString());
            }
            Console.WriteLine("Sum of all multiples: " + totalOfAllMultiples.ToString());
            Console.ReadLine();
        }
    }
}
using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The process of finding the maximum value (i.e., the largest
    /// of a group of values) is used frequently in computer applications.
    /// For example, an app that determines the winner of a sales contest
    /// would input the number of units sold by each salesperson. The
    /// salesperson who sells the most units wins the contest.
    /// Write pseudocode, then a C# app that inputs a series of 10 integers,
    /// then determines and displays the largest integer followed by the
    /// second largest integer.
    /// Your app should use at least the following four variables:
    ///     counter: A counter to count to 10 (i.e., to keep track of
    ///        how many numbers have been input and to determine when all
    ///        10 numbers have been processed).
    ///     number (integer): The integer most recently input by the user.
    ///     largest: The largest number found so far.
    ///     largest2: The second largest number found so far.
    /// </summary>
    public class LargestNumbers
    {
        public static void Main()
        {
            /*
             * Set int values to Zero
             * Prompt the user to input 10 integers
             * Loop until the 10th entry
             * If number is more than the largest number
             * Set 2nd Largest number equal to largest number & set largest number equal to number
             * else if number is more than the 2nd largest number
             * Set 2nd Largest number equal to number
             * Print Largest Number
             * Print 2nd Largest Number
             */


            // get first number and assign it to variable largest
            // write your codes here

            int i = 0, num = 0, largest_num1 = 0, largest_num2 = 0;

            // To keep tracking the largest value
            largest_num1 = int.MinValue;

            while (i < 10)
            {
                Console.Error.WriteLine("Enter an Integer");
                num = int.Parse(Console.ReadLine());
                i++;

                if (num > largest_num1)
                {
                    largest_num2 = largest_num1;
                    largest_num1 = num;
                }

                else if (num > largest_num2)
                {
                    largest_num2 = num;
                }
            }

            Console.WriteLine($"The Largest Entered Number is {largest_num1}");
            Console.WriteLine($"The Second Largest Entered Number is {largest_num2}");

        }
    }
}

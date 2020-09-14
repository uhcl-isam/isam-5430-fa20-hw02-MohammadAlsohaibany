using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// The Main app will prompt the user for the last number of the Fibonacci numbers.
    /// Then, the app will write a sequence of numbers in a Fibonacci sequence up to the last number.
    /// Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci sequence, 
    /// and characterized by the fact that every number after the first two is the sum of the two preceding ones.
    /// The first two numbers are 0 and 1 so the numbers will be 0 1 1 2 3 5 8 13 21 34 55 89...
    /// </summary>
    public class FibonacciNumbers
    {
        public static void Main()
        {
            int count, n1 = 0, n2 = 1;
            
            Console.WriteLine("Enter a number");

            string input = Console.ReadLine();
            count = Convert.ToInt32(input);
            int i = 0;
            while (i <= count)
            {
                Console.Write(n1 + " ");
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                i++;


            }

           
        }
    }
}

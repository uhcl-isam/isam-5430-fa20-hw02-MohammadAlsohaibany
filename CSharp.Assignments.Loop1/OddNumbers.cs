using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            /* My idea is to take 2 variable entries and run the numbers between num1 & num2 inclusive
               and if num1 % 2 doesn't equal Zero, then print num1 and move to the next number
            */

            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            int num1 = int.Parse(Console.ReadLine());
            Console.Error.WriteLine("Enter the ending number");
            // Codes to enter end.
            int num2 = int.Parse(Console.ReadLine());

            while (num1 <= num2)
            {
                if ((num1 % 2) != 0)
                {
                    Console.WriteLine(num1);
                }
                num1++;

            }
        }
    }
}

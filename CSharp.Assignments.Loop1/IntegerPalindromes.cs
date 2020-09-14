using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.
            int num = 0, num2, reminder, reverse = 0;
            do
            {
                Console.WriteLine("Enter exactly 9-digit positive integers : ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num.ToString().Length == 9)
                {
                    num2 = num;


                    while (num2 != 0)
                    {
                        reminder = num2 % 10;
                        reverse = (reverse * 10) + reminder;
                        num2 /= 10;
                    }

                    //  if num and num2 are equal palindrome
                    if (num == reverse)
                        Console.WriteLine("a palindrome");
                    else
                        Console.WriteLine("not a palindrome");

                }
                else
                    Console.WriteLine("The number is Not 9 digit, enter correct number ");

            } while (num.ToString().Length != 9);
        }
    }
}

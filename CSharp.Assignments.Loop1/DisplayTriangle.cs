using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {
        public static void Main()
        {
            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char triangle = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());

            // Write your codes here.
            //Console.ReadLine();

            // for a
            if (triangle == 'a')
            {
                int i = 1;
                while (i <= n)
                {
                    int j = 1;
                    while (j <= i)
                    {
                        Console.Error.Write("*");
                        Console.Error.WriteLine("");
                        j++;
                    }
                    i++;
                }
            }

            // for b
            else if (triangle == 'b')
            {
                int i = n;
                while (i >= 1)
                {
                    int j = 1;
                    while (j <= i)
                    {
                        Console.Error.Write("*");
                        Console.Error.WriteLine("");
                        j++;
                    }
                    i--;
                }
            }

            // for c
            else if (triangle == 'c')
            {
                int i = n;
                while (i >= 1)
                {
                    int j = n - i;
                    while (j >= 1)
                    {
                        Console.Write(" ");
                        j--;
                    }

                    int k = i;
                    while (k >= 1)
                    {
                        Console.Write("*");
                        k--;
                    }
                    Console.WriteLine("");
                    i--;
                }
            }
            
            // for d
            else if (triangle == 'd')
            {
                int i = 1;
                while (i <= n)
                {
                    int j = 1;
                    while (j <= n - i)
                    {
                        Console.Write(" ");
                        j++;
                    }

                    int k = 1;
                    while (k <= i)
                    {
                        Console.Write("*");
                        k++;
                    }

                    Console.WriteLine("");
                    i++;
                }

            }

            Console.ReadLine();
        }
    }
}

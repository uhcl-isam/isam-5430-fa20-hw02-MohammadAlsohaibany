using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    public class SquareUp
    {
        /// <summary>
        /// Create an app that inputs one number, n >= 0. The app will print out n*n integers with the following pattern; for n=3, the app will print out 0, 0, 1,    0, 2, 1,    3, 2, 1 on separate lines (spaces added to show the 3 groups).
        /// </summary>
        public static void Main()
        {
            // Write your codes here
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int m = 0;
                    int x = 0;
                    for (int p = i * n; p < (i + 1) * n; p++)
                    {
                        if (m < n - i - 1)
                        {
                            Console.Write("0, ");
                            m++;
                        }
                        else
                        {

                            Console.Write((i + 1 - x) + ", ");

                            x++;
                        }
                    }
                    Console.WriteLine("");
                }
            }
            else
                Console.WriteLine("Wrong input number");



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here
            string line;
            int clumb = 0, count = 0;
            Console.WriteLine("Enter bunch of integers  (press CTRL+Z to exit):");
            Console.WriteLine();
            do
            {
                Console.Write("   ");
                line = Console.ReadLine();
                if (line != null)
                {
                    // convert to integer
                    int val = Convert.ToInt32(line);

                    if (val == clumb)
                        count++;
                    clumb = val;
                }

            } while (line != null);
            Console.WriteLine("  The counts of clumbs    " + count);
        }
    }
}

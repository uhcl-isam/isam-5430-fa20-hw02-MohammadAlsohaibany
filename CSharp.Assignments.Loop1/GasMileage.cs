using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Drivers are concerned with the mileage their automobiles get.
    /// One driver has kept track of several tankfuls of gasoline by 
    /// recording the miles driven and gallons used for each tankful. 
    /// Develop a C# app that will input the miles driven and gallons
    /// used (both as integers) for each tankful. The app should calculate
    /// and display the miles per gallon obtained for each tankful and 
    /// display the combined miles per gallon obtained for all tankfuls
    /// up to this point. All averaging calculations should produce
    /// floating-point results. Display the miles per gallons on one line
    /// and the total miles per gallons on another, both rounded to the
    /// nearest hundredth, immediately after each input. Use the Console
    /// class’s ReadLine method and sentinel-controlled iteration
    /// (e.g. when miles driven are negative, the loop ends) to
    /// obtain the data from the user.
    /// </summary>
    public class GasMileage
    {
        public static void Main()
        {
            // prompt user for non-negative miles and obtain the input from user
            // codes go here.

            int miles, galoon;
            double mileage = 0;
            int total_miles = 0, total_gallon = 0, tankfuls = 1;

            do
            {
                Console.WriteLine("Enter miles driver (negative number to exit ) for tankfuls No : " + tankfuls);
                miles = Convert.ToInt32(Console.ReadLine());
                if (miles <= 0)
                    break;
                Console.WriteLine("Enter used galoon for tankfuls No : " + tankfuls);
                galoon = Convert.ToInt32(Console.ReadLine());
                total_miles = total_miles + miles;
                total_gallon = total_gallon + galoon;
                tankfuls++;
            } while (miles > 0);
            mileage = Convert.ToDouble(total_miles) / total_gallon;
            Console.WriteLine("the mileage is : " + mileage + " per galoon");

        }
    }
}

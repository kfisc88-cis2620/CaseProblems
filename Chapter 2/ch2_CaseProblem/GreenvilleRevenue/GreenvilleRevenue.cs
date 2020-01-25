// Filename: GreenvilleRevenue.cs
// Written by: Kelley Fischer & Ian Lundquist
// Written on: 01/24/20
// Description: 
//      Chapter 2 - Case Problem 1
//      Prompts user for the number of contestants, then displays the input, calculates the revenue for each
//      year and displays the total and difference between them.
// Encountered Issues: None;

using System;

namespace CaseProblem1
{
    class GreenvilleRevenue
    {
        static void Main(string[] args)
        {
            const double FEE = 25.00;

            int entrantsThisYear, 
                entrantsLastYear;

            double revenueLastYear, 
                revenueThisYear;

            string numContestants;

            // Gets number of contestants from user, converts string to integer, then displays the input.
            Console.WriteLine("Please enter the number of contestants from last year: ");
            numContestants = Console.ReadLine();
            entrantsLastYear = Convert.ToInt32(numContestants);
            Console.WriteLine("The number of contestants entered this year is {0}.\n", entrantsLastYear);

            // Gets number of contestants from user, converts string to integer, then displays the input.
            Console.WriteLine("Please enter the number of contestants this year: ");
            numContestants = Console.ReadLine();
            entrantsThisYear = Convert.ToInt32(numContestants);
            Console.WriteLine("The number of contestants entered this year is {0}.\n", entrantsThisYear);

            // Caluclates the revenue for each year
            revenueThisYear = FEE * entrantsThisYear;
            revenueLastYear = FEE * entrantsLastYear;

            // Displays the revenue for each year and calculates the difference between them.
            Console.WriteLine("This years revenue was {0}.", revenueThisYear.ToString("C"));
            Console.WriteLine("Last years revenue was {0}.", revenueLastYear.ToString("C"));
            Console.WriteLine("The difference between this year and last year's revenue was {0}.", (revenueThisYear - revenueLastYear).ToString("C"));
        }
    }
}

// Filename: GreenvilleMotto2.cs
// Written by: Kelley Fischer & Ian Lundquist
// Written on: 01/24/20
// Description: 
//      Chapter 2 - Case Problem 1
//      
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

            Console.WriteLine("Please enter the number of contestants from last year: ");
            numContestants = Console.ReadLine();
            entrantsLastYear = Convert.ToInt32(numContestants);
            
            Console.WriteLine("Please enter the number of contestants this year: ");
            numContestants = Console.ReadLine();
            entrantsThisYear = Convert.ToInt32(numContestants);

            revenueThisYear = FEE * entrantsThisYear;
            revenueLastYear = FEE * entrantsLastYear;

            Console.WriteLine("Last years revenue was {0}.", revenueLastYear);
            Console.WriteLine("This years revenue was {0}.", revenueThisYear);
            
        }
    }
}

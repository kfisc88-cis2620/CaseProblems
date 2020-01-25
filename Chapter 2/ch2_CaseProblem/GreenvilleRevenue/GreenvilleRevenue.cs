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
            int entrantsThisYear, 
                entrantsLastYear,
                revenueLastYear,
                revenueThisYear;

            string numContestants;

            Console.WriteLine("Please enter the number of contestants from last year: ");
            numContestants = Console.ReadLine();
            entrantsLastYear = Convert.ToInt32(numContestants);
            
            Console.WriteLine("Please enter the number of contestants this year: ");
            numContestants = Console.ReadLine();
            entrantsThisYear = Convert.ToInt32(numContestants);



        }
    }
}

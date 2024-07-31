using System;

namespace GoalSeekExample
{
    class Program
    {
        static double CalculateTotalBudget(double adBudget, double agencyFee, double thirdPartyFee, double fixedCost, double X1, double X2)
        {
            // X = X1 + X2 + X3
            // Total Budget = X + Z * Y1 + Y2 * X + HOURS
            double X = X1 + X2 + adBudget;
            double totalBudget = X + (X * agencyFee) + (X * thirdPartyFee) + fixedCost;
            return totalBudget;
        }

        static double GoalSeek(double targetBudget, double initialGuess, double agencyFee, double thirdPartyFee, double fixedCost, double X1, double X2)
        {
            double specificAdBudget = initialGuess;
            double tolerance = 0.01; // Acceptable error margin

            while (true)
            {
                double totalBudget = CalculateTotalBudget(specificAdBudget, agencyFee, thirdPartyFee, fixedCost, X1, X2);

                if (Math.Abs(totalBudget - targetBudget) < tolerance)
                    break;

                // Update estimate based on the difference between target and calculated total budget
                double adjustment = (targetBudget - totalBudget) / (1 + agencyFee + thirdPartyFee);
                specificAdBudget += adjustment;
            }

            return specificAdBudget;
        }

        static void Main(string[] args)
        {
            // Example values
            double targetBudget = 1000; // Target total budget (Z)
            double initialGuess = 100; // Initial guess (X3)
            double agencyFee = 0.1; // Agency fee percentage (Y1)
            double thirdPartyFee = 0.05; // Third-party tool fee percentage (Y2)
            double fixedCost = 50; // Fixed cost (HOURS)

            double X1 = 200; // Budget for ad X1
            double X2 = 250; // Budget for ad X2

            double maxSpecificAdBudget = GoalSeek(targetBudget, initialGuess, agencyFee, thirdPartyFee, fixedCost, X1, X2);

            Console.WriteLine($"The optimal budget for a specific ad X3 is: {maxSpecificAdBudget:C}");
        }
    }
}



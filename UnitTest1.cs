namespace CampaignBudgetOptimizer.Tests
{
    public class Tests
    {
        // SetUp: Code that will run once before each test.
        [SetUp]
        public void Setup()
        {
            // This method allows you to set up common data or perform any initialization before running the tests.
        }

        // The actual test method.
        [Test]
        public void TestCalculateTotalBudget()
        {
            // Arrange: Preparing necessary data for the test.
            double adBudget = 100;             // Advertising budget
            double agencyFee = 0.1;            // Agency fee percentage
            double thirdPartyFee = 0.05;       // Third-party tool fee percentage
            double fixedCost = 50;             // Fixed cost
            double X1 = 200;                   // Budget for ad X1
            double X2 = 250;                   // Budget for ad X2

            // Act: Calling the method being tested.
            double result = CalculateTotalBudget(adBudget, agencyFee, thirdPartyFee, fixedCost, X1, X2);

            // Assert: Verifying if the result is correct.
            double expected = 1000;           // Expected result
            Assert.AreEqual(expected, result); // Comparing the result with the expected value.
        }
    }
}


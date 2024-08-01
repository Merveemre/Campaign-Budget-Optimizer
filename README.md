# Campaign Budget Optimizer

## Project Description

The **Campaign Budget Optimizer** is a C# application that calculates the optimal budget for a specific ad in a campaign, ensuring the total budget remains within the predefined limits.

## How to Run the Application

### Prerequisites

- [.NET SDK 6.0](https://dotnet.microsoft.com/download) or later installed on your machine.

### Installation Steps

1. **Clone the Repository**

    ```bash
    git clone https://github.com/yourusername/Campaign-Budget-Optimizer.git
    cd Campaign-Budget-Optimizer
    ```

2. **Restore Dependencies**

    ```bash
    dotnet restore
    ```

3. **Build the Project**

    ```bash
    dotnet build
    ```

4. **Run the Application**

    ```bash
    dotnet run --project CampaignBudgetOptimizer.csproj
    ```

5. **Run the Tests**

    To ensure the application works as expected, unit tests are included. You can run these tests using the following commands:

    ```bash
    cd CampaignBudgetOptimizer.Tests
    dotnet test
    ```

    This will execute the unit tests and display the results in the console, helping you verify that the application logic is correct.

## Additional Information

- Ensure your environment meets the prerequisites before running the application.


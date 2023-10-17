using System;

class MonteCarloIntegration
{
    static void Main()
    {
        Random random = new Random();
        int insideArea = 0;
        int totalPoints = 100000; // Number of random points

        for (int i = 0; i < totalPoints; i++)
        {
            double x = random.NextDouble();
            double y = random.NextDouble();

            if (y <= FunctionToIntegrate(x))
                insideArea++;
        }

        double estimatedArea = (double)insideArea / totalPoints;
        Console.WriteLine($"Estimated area with {totalPoints} samples: {estimatedArea}");
    }

    static double FunctionToIntegrate(double x)
    {
        // Define your own function here
        return x * x;
    }
}

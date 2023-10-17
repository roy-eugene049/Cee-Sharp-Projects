using System;

class MonteCarloPi
{
    static void Main()
    {
        Random random = new Random();
        int insideCircle = 0;
        int totalPoints = 1000000; // Number of random points

        for (int i = 0; i < totalPoints; i++)
        {
            double x = random.NextDouble();
            double y = random.NextDouble();
            double distance = x * x + y * y;

            if (distance <= 1)
                insideCircle++;
        }

        double estimatedPi = 4.0 * insideCircle / totalPoints;
        Console.WriteLine($"Estimated π with {totalPoints} samples: {estimatedPi}");
    }
}

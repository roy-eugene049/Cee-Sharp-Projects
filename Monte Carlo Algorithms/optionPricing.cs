using System;
using MathNet.Numerics.Distributions;

class MonteCarloOptionPricing
{
    static void Main()
    {
        double S = 100; // Current stock price
        double K = 105; // Strike price
        double r = 0.05; // Risk-free interest rate
        double T = 1.0; // Time to expiration (in years)
        double volatility = 0.2; // Annual volatility
        int numSimulations = 10000;

        double optionPrice = MonteCarloOptionPrice(S, K, r, T, volatility, numSimulations);
        Console.WriteLine($"Estimated option price: {optionPrice:C}");
    }

    static double MonteCarloOptionPrice(double S, double K, double r, double T, double volatility, int numSimulations)
    {
        double dt = T / 252.0; // Assuming 252 trading days in a year
        double optionPrice = 0;

        for (int i = 0; i < numSimulations; i++)
        {
            double price = S;

            for (int j = 0; j < 252; j++)
            {
                double z = Normal.Sample(0, 1);
                price *= Math.Exp((r - 0.5 * volatility * volatility) * dt + volatility * Math.Sqrt(dt) * z);
            }

            double payoff = Math.Max(0, price - K);
            optionPrice += payoff;
        }

        optionPrice /= numSimulations;
        optionPrice *= Math.Exp(-r * T);
        return optionPrice;
    }
}

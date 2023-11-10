using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer to check if it's prime:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (FindPrime(number))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    internal static bool FindPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var squareRoot = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= squareRoot; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}
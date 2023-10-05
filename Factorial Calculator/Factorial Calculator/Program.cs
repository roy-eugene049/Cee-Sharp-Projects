using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is undefined for negative numbers.");
        }
        else
        {
            BigInteger factorial = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
    }

    static BigInteger CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Factorial is undefined for negative numbers.");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

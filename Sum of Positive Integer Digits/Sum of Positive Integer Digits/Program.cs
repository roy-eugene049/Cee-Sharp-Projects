using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Integer to get sum of digits");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int parsedInput))
        {
            SumOfDigits(parsedInput);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    internal static void SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine(sum);
    }
}
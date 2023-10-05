using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial");
        int number = int.Parse(Console.ReadLine());

        if ( number < 0 )
        {
            Console.WriteLine("Factorial is undefined for negative number.");
        } else
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
    }


    static long CalculateFactorial(int n)
    {
        if ( n == 0 )
        {
            return 1;
        } else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}
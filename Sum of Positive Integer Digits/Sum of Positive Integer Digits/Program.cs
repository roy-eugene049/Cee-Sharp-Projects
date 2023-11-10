using System;

class Program
{
    static void Main(string[] args)
    {
        
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
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter unsorted integers separated by spaces:");
        string userInput = Console.ReadLine();

        // Split the input string into an array of integers
        int[] intArray = Array.ConvertAll(userInput.Split(' '), int.Parse);

        FindSecondLargeInArray(intArray);
    }

    internal static void FindSecondLargeInArray(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        foreach (int i in arr)
        {
            if (i > max1)
            {
                max2 = max1;
                max1 = i;
            }
            else if (i >= max2 && i != max1)
            {
                max2 = i;
            }
        }
        Console.WriteLine("Second largest integer in the array is: " + max2); ;
    }
}
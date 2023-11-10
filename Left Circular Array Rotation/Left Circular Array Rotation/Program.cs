using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces(integers):");
        string input = Console.ReadLine();

        // Convert the user input to an array of integers
        int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

        // Call the RotateLeft method
        RotateLeft(array);
    }

    internal static void RotateLeft(int[] array)
    {
        int size = array.Length;
        int temp;
        for (int j = size - 1; j > 0; j--)
        {
            temp = array[size - 1];
            array[array.Length - 1] = array[j - 1];
            array[j - 1] = temp;
        }

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
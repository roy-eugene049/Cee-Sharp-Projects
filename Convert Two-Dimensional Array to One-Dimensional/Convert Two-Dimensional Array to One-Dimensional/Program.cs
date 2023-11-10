using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the dimensions of the 2D array:");
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        Console.WriteLine($"Enter {rows * columns} elements for the 2D array:");

        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < columns; x++)
            {
                Console.Write($"Enter element at position [{x},{y}]: ");
                array[x, y] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Original 2D Array:");
        PrintArray(array);

        Console.WriteLine("\nResulting 1D Array:");
        MultiToSingle(array);
    }

    internal static void MultiToSingle(int[,] array)
    {
        int index = 0;
        int width = array.GetLength(0);
        int height = array.GetLength(1);
        int[] single = new int[width * height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                single[index] = array[x, y];
                Console.Write(single[index] + " ");
                index++;
            }
        }
    }

    internal static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int y = 0; y < columns; y++)
        {
            for (int x = 0; x < rows; x++)
            {
                Console.Write(array[x, y] + " ");
            }
            Console.WriteLine();
        }
    }
}
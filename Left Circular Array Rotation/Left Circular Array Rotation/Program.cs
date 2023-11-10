using System;

class Program
{
    static void Main(string[] args)
    {

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
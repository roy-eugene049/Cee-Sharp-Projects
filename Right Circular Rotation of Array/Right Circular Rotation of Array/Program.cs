using System;

class Program
{
    static void Main(string[] args)
    {

    }

    internal static void RotateRight(int[] array)
    {
        int size = array.Length;
        int temp;
        for (int j = 0; j < size - 1; j++)
        {
            temp = array[0];
            array[0] = array[j + 1];
            array[j + 1] = temp;
        }
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
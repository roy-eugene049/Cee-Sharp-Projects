﻿using System;

class Program
{
    static void Main(string[] args)
    {

    }

    internal static void FindthirdLargeInArray(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int max3 = int.MinValue;

        foreach (int i in arr)
        {
            if (i > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = i;
            }
            else if (i > max2 && i != max1)
            {
                max3 = max2;
                max2 = i;
            }
            else if (i > max3 && i != max2 && i != max1)
            {
                max3 = i;
            }
        }
        Console.WriteLine(max3); ;
    }
}
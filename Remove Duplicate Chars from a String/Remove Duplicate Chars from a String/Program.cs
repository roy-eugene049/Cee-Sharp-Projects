using System;

class Program
{
    static void Main(string[] args)
    {

    }
    internal static void removeduplicate(string str)
    {
        string result = string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            if (!result.Contains(str[i]))
            {
                result += str[i];
            }
        }
        Console.WriteLine(result);
    }
}
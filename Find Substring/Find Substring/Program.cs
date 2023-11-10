using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string userString = Console.ReadLine();
        findallsubstring(userString);
    }

    internal static void findallsubstring(string str)
    {
        for (int i = 0; i < str.Length; ++i)
        {
            StringBuilder subString = new StringBuilder(str.Length - i);
            for (int j = i; j < str.Length; ++j)
            {
                subString.Append(str[j]);
                Console.Write(subString + " ");
            }
        }
    }
}
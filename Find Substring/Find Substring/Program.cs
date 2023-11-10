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


/*
 Outer Loop
 The outer loop runs from i - 0 to i - n - 1
 For each i, it represents the starting index of the substring

 Inner Loop
 The inner loop runs from j - i to j - n - 1
 For each j, it represents the ending index of the substring
 The loop constructs a substring by appending characters from s[j] to the 
 previously constructed characters, forming substrings of increasing length.
*/
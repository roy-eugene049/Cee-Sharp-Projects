using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Palindrome Checker!");

        Console.WriteLine("Enter a word or number to check for palindrome: ");
        string inputString = Console.ReadLine();

        chkPalindrome(inputString);
    }

    internal static void chkPalindrome(string str)
    {
        bool flag = true; // Initialize the flag to true
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            if (str[i] != str[j])
            {
                flag = false; // If a character mismatch is found, set the flag to false and exit the loop
                break;
            }
        }

        if (flag)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}

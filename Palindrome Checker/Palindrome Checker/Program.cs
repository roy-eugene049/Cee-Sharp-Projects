using System;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        bool continueChecking = true;

        while (continueChecking)
        {
            //Get input from user
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //Remove spaces and convert to lowercase
            string cleanInput = input.Replace(" ", "").ToLower();

            //check if the modified sring is a palindrome
            bool isPalindrome = IsPalindrome(cleanInput);

            //display the result
            if (isPalindrome)
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome");
            }

            //check if the user wants to continue
            Console.Write("Do you want to check another word? (yes/no)");
            string response = Console.ReadLine();

            if (response.ToLower() != "yes")
            {
                Console.WriteLine("Thanks for playing");
                continueChecking = false;
            }
        }

        //function to check if a string is a palindrome
        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
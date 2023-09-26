using System;

class Program
{
    static void Main()
    {
        bool continueChecking = true;

        while (continueChecking)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();


            //Remove spaces and convert to lowercase
            string cleanInput = input.Replace(" ", "").ToLower();

            //Check for palindrome
            bool isPalindrome = IsPalindrome(cleanInput);

            //Display the result
            if (isPalindrome)
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }

            Console.Write("Do you want to check another word? (yes/no): ");
            string response = Console.ReadLine();

            //check if the user wants to continue
            if (response.ToLower() != "yes")
            {
                Console.WriteLine("Thanks for playing.");
                continueChecking = false;
            }

        }
    }

    //Function to check if a string is palindrome
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
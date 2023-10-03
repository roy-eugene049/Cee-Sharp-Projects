using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool playAgain = true;
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine().ToUpper();
        Console.WriteLine($"Welcome to the Anagram Checker game {userName}!");

        while (playAgain)
        {
            
            Console.Write("Enter the first string: ");
            string string1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string string2 = Console.ReadLine();

            // Remove spaces and convert to lowercase
            string1 = RemoveSpacesAndToLower(string1);
            string2 = RemoveSpacesAndToLower(string2);

            // Check if string lengths are equal
            if (string1.Length != string2.Length)
            {
                Console.WriteLine("Not Anagrams (different lengths)");
            }
            else
            {
                // Sort characters
                string1 = SortCharacters(string1);
                string2 = SortCharacters(string2);

                // Compare sorted strings
                if (string1 == string2)
                {
                    Console.WriteLine("Anagrams");
                }
                else
                {
                    Console.WriteLine("Not Anagrams");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();

            if (playAgainResponse != "yes")
            {
                playAgain = false;
                Console.WriteLine($"Goodbye, {userName}! Thanks for playing!");
            }
        }
    }

    static string RemoveSpacesAndToLower(string input)
    {
        return new string(input.Where(c => !Char.IsWhiteSpace(c)).ToArray()).ToLower();
    }

    static string SortCharacters(string input)
    {
        char[] characters = input.ToCharArray();
        Array.Sort(characters);
        return new string(characters);
    }
}

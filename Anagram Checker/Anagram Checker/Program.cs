using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the game! Enter your name: ");
        string userName = Console.ReadLine().ToUpper();

        Console.Write("Enter the first string: ");
        string string1 = Console.ReadLine();

        Console.Write("Enter the second String: ");
        string string2 = Console.ReadLine();

        //remove spaces and convert to lower case
        string1 = RemoveSpacesAndToLower(string1);
        string2 = RemoveSpacesAndToLower(string2);

        //check if string lengths are equal
        if (string1.Length != string2.Length)
        {
            Console.WriteLine("Not Anagrams (different lengths)");
        } else
        {
            //sort characters
            string1 = SortCharacters(string1);
            string2 = SortCharacters(string2);

            //compare sorted strings
            if (string1 == string2)
            {
                Console.WriteLine("Anagrams");
            } else
            {
                Console.WriteLine("Not Anagrams");
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
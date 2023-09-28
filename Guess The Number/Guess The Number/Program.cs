using System;

class Program
{
    public static string userName = Console.ReadLine().ToUpper();
    static void Main()
    {
        // User Welcome Message
        Console.WriteLine("Enter your name: ");

        Console.WriteLine($"\nWelcome to the Guess The Number Game {userName}!");
        Console.WriteLine("........................................ \n");

        bool playAgain = true;

        while (playAgain)
        {

            // Get the minimum and maximum values for the input range
            int minimum = GetUserInput("Enter the minimum value:  ");
            int maximum = GetUserInput("Enter the maximum value: ");

            // Generate a random number within the specified range
            Random random = new Random();
            int SecretNumber = random.Next(minimum, maximum + 1);
            int numberOfGuesses = 0;

            Console.WriteLine("........................................ \n");
            Console.WriteLine($"Guess a number between {minimum} and {maximum}");


            while (true)
            {
                int userGuess = GetUserInput("Enter your guess: ");
                numberOfGuesses++;

                if (userGuess == SecretNumber)
                {
                    Console.WriteLine("........................................ \n");
                    Console.WriteLine($"Congratulations {userName}! You guessed the correct number in {numberOfGuesses} guesses! \n");
                    break;
                }
                else if (userGuess < SecretNumber)
                {
                    Console.WriteLine("Try a higher value You got this!");
                }
                else
                {
                    Console.WriteLine("Try a lower value");
                }
            }
            playAgain = GetYesOrNoInput("Do you want to play again? (yes / no)");
        }
        Console.WriteLine("Thanks for playing!");
    }

    static int GetUserInput(string message)
    {
        int value;
        bool validInput;

        do
        {
            Console.Write(message);
            validInput = int.TryParse(Console.ReadLine(), out value);

            if (!validInput)
            {
                Console.WriteLine($"Invalid input {userName}. Please enter a valid number");
            }
        } while (!validInput);

        return value;
    }

    static bool GetYesOrNoInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                return true;
            }
            else if (response == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine($"Invalid input {userName}. Please enter 'Yes' or 'No'");
            }
        }
    }
}
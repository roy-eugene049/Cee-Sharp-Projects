using System;

class Program
{
    static void Main()
    {
        //User welcome message
        Console.WriteLine("Enter your Name: ");
        string userName = Console.ReadLine().ToUpper();
        Console.WriteLine($"\nWelcome to the Guess The Number Game {userName}!");

        bool playAgain = true;

        while (playAgain)
        {
            //get the minimum and maximum values for the range
            Console.WriteLine("........................................ \n");
            int minimum = GetUserInput("Enter the minimum value: ");
            int maximum = GetUserInput("Enter the maximum value: ");

            //generate a random number within the specified range
            Random random = new Random();
            int secretNumber = random.Next(minimum, maximum + 1);
            int numberOfGuesses = 0;

            Console.WriteLine("........................................ \n");
            Console.WriteLine($"Guess a number between {minimum} and {maximum}.");


            while (true)
            {
                int userGuess = GetUserInput("Enter your guess: ");
                numberOfGuesses++;

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("........................................ \n");
                    Console.WriteLine($"Congratulations {userName}! You guessed the correct number in {numberOfGuesses} guesses! \n");
                    break;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Try a lower number");
                }
            }
            playAgain = GetYesOrNoInput("Do you want to play again? (yes/no)");
        }
        Console.WriteLine($"Thanks for playing {userName}!");
    }

    static int GetUserInput (string message)
    {
        int value;
        bool validInput;

        do
        {
            Console.Write(message);
            validInput = int.TryParse(Console.ReadLine(), out value);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
        } while (!validInput);

        return value;
    }

    static bool GetYesOrNoInput (string message)
    {
        while (true)
        {
            Console.Write(message);
            string response = Console.ReadLine().ToLower();

            if ( response == "yes" )
            {
                return true;
            } else if ( response == "no" )
            {
                return false;
            } else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Coin Flip Game!");
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        bool playAgain = true;
        Random random = new Random();

        while (playAgain)
        {
            int coinValue = random.Next(2);
            string result = coinValue == 0 ? "Heads" : "Tails";

            Console.WriteLine($"Hello, {userName}! The coin landed on {result}.");

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput != "yes")
            {
                playAgain = false;
                Console.WriteLine("Goodbye! Thanks for playing.");
            }
        }
    }
}

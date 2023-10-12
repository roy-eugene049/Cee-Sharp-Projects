using System;

class Program
{
    static void Main()
    {

        //The following code sample uses a nullable type string to capture user input.
        //The iteration continues while the user-supplied value is null:
        //string? readResult;
        //Console.WriteLine("Enter a string:");
        //do
        //{
        //    readResult = Console.ReadLine();
        //} while (readResult == null);

        //The Boolean expression evaluated by the while statement can be used to ensure user input meets a specified requirement.
        //For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:
        //string? readResult;
        //bool validEntry = false;
        //Console.WriteLine("Enter a string containing at least three characters:");
        //do
        //{
        //    readResult = Console.ReadLine();
        //    if (readResult != null)
        //    {
        //        if (readResult.Length >= 3)
        //        {
        //            validEntry = true;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Your input is invalid, please try again.");
        //        }
        //    }
        //} while (validEntry == false);

        //If you want to use Console.ReadLine() input for numeric values, you need to convert the string value to a numeric type.

        //The int.TryParse() method can be used to convert a string value to an integer.
        //The method uses two parameters, a string that will be evaluated and the name of an integer variable that will be assigned a value.
        //The method returns a Boolean value. The following code sample demonstrates using the int.TryParse() method:
        // capture user input in a string variable named readResult

        //int numericValue = 0;
        //bool validNumber = false;

        //validNumber = int.TryParse(readResult, out numericValue);

        //If the string value assigned to readResult represents a valid integer, the value will be assigned to the integer variable named numericValue,
        //and true will be assigned to the Boolean variable named validNumber.
        //If the value assigned to readResult doesn't represent a valid integer, validNumber will be assigned a value of false.
        //For example, if readResult is equal to "7", the value 7 will be assigned to numericValue.


        //Code Project 1: Write code that validates user input


        //This is the beginning of my first attempt to this challenge
        //string? userInput;
        //Console.WriteLine("Enter an integer value between 5 and 10");


        //do
        //{
        //    if (userInput != null)
        //    {
        //        if (userInput <= 5 || userInput >= 10)
        //        {
        //            Console.WriteLine("You entered an invalid number, please try again");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Your input {(userInput)} has been accepted");
        //        }
        //    }
        //} while (userInput > 5 && userInput < 10);

        //Here is the refactored solution:

        //string userInput;
        //int number; // Variable to store the parsed integer

        //Console.WriteLine("Enter an integer value between 5 and 10");

        //do
        //{
        //    userInput = Console.ReadLine(); // Read user input as a string

        //    if (int.TryParse(userInput, out number)) // Try to parse the input as an integer
        //    {
        //        if (number < 5 || number > 10)
        //        {
        //            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Your input ({number}) has been accepted");
        //            break; // Exit the loop when a valid number is provided
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //    }
        //} while (true); // Continue the loop until a valid input is provided

        //Code Project 2: Add code that validates string input

        string? userInput;
        string[] roles = { "Aministrator", "Manager", "User" };

        do
        {
            //Get input from user
            Console.WriteLine("Enter your role name (Aministrator, Manager, or User: ");
            userInput = Console.ReadLine();

            bool isValidInput = false;

            foreach (string role in roles)
            {
                if (userInput.Equals(role, StringComparison.OrdinalIgnoreCase))
                {
                    isValidInput = true;
                    break; //Exit the loop when a match is found
                }
            }

            if (!isValidInput)
            {
                Console.WriteLine($"The role that you entered ({userInput}) is not valid. Enter a valid role name (Administrator, Manager, or User)");
            }
            else
            {
                Console.WriteLine($"Your input value ({userInput}) has been accepted");
                break; //If you want the user to keep playing, remove this break statement
            }
        } while (true);
    }
}
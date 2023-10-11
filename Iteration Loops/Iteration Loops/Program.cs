using System;

class Program
{
    static void Main()
    {
        //Increment Scenario
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        //Decrement Scenario
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        //Experiment with the iterator's parameters
        for (int i = 0; i < 12; i += 2)
        {
            Console.WriteLine(i);
            if (i == 8) break;
        }

        //Use the break keyword to break the iteration statement
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }

        //loop through each element of an array using for loop customization
        string[] names = { "Yor", "Rio", "Roy", "Ryo" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }
        //notice that we are using the Array.Length property to get the number of elements in the array,
        //and that we are using this value to initialize our iterator variable (int i = names.Length - 1).
        //We subtract 1 from the value because the index number for array elements is zero-based (the index numbers of the four elements are 0-3).
        //Finally, notice we have chosen iterate through the array backwards--something that we are unable to do with the foreach statement.
        //We use the value of the iteration variable inside the code block to specify the index number of the array elements (names[i]).

        //Examine the limitation of the foreach statement
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        foreach (var name in names)
        {
            // Can't do this:
            if (name == "David") name = "Sammy";
        }

        //Overcoming the limitation of the foreach statement using the for statement
        //Curly braces removed for code blocks with a single line of code
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
            if (names[i] == "David") names[i] = "Sammy";

        //Same code with the normal code clock structure
        string[] names = { "Sammy", "Dodhia", "Vuzi", "Kanyuto" };

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "Vuzi") names[i] = "Shmack";
        }


        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        foreach (var name in names) Console.WriteLine(name);
        //Since the array isn't directly part of the iteration statement's implementation, you can change values inside of the array.

        //Do - While Loop Logic
        //syntax
        do
        {
            // This code executes at least one time
        } while (true)
        Random random = new Random();
        int current = 0;

        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);

        //Since the numbers generated are random, your results will be different.
        //However, the value 7 will be the last number to be printed as the Boolean expression will evaluate to true when 7 is generated and the flow of execution will exit the code.

        //Write a while statement that iterates only while a random number is greater than some value
        Random random = new Random();
        int current = random.Next(1, 11);

        /*
        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);
        */

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
        //In this case, we position the while keyword and the Boolean expression before the code block.
        //This changes the meaning of the code and acts as a "gate" to only allow the flow of execution to enter if the Boolean expression evaluates to true.

        //Use the continue statement to step directly to the Boolean expression
        Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);

        /*
        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
        */
        //The first thing that we do inside the code block is to assign a new random value to current.
        //Next, we check to see if current is greater than or equal to 8.
        //If this expression returns true, the continue key word will transfer control to the end of the code block and the while will evaluate (current != 7).
        //So, the loop will continue to iterate as long as the value of current is not equal to 7.
        //Since our code that writes the value of current to the console is located after the if (current >= 8) continue;,
        //our code ensures that a value of current that is greater than or equal to 8 will never be written to the output window.

        //N.B: he continue statement transfers execution to the end of the current iteration.
        //This behavior is different than the behavior we saw with the break statement.
        //The break statement terminates the iteration (or switch) and transfers control to the statement that follows the terminated statement.
        //If there is no statement after the terminated statement, then control transfers to the end of the file or method.


    }
}
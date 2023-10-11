using System;

class Program
{
    static void Main()
    {
        //Increment Scenario
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //Decrement Scenario
        //for (int i = 10; i >= 0; i--)
        //{
        //    Console.WriteLine(i);
        //}

        //Experiment with the iterator's parameters
        //for (int i = 0; i < 12; i += 2)
        //{
        //    Console.WriteLine(i);
        //    if (i == 8) break;
        //}

        //Use the break keyword to break the iteration statement
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //    if (i == 7) break;
        //}

        //loop through each element of an array using for loop customization
        //string[] names = { "Yor", "Rio", "Roy", "Ryo" };
        //for (int i = names.Length - 1; i >= 0; i--)
        //{
        //    Console.WriteLine(names[i]);
        //}
        //notice that we are using the Array.Length property to get the number of elements in the array,
        //and that we are using this value to initialize our iterator variable (int i = names.Length - 1).
        //We subtract 1 from the value because the index number for array elements is zero-based (the index numbers of the four elements are 0-3).
        //Finally, notice we have chosen iterate through the array backwards--something that we are unable to do with the foreach statement.
        //We use the value of the iteration variable inside the code block to specify the index number of the array elements (names[i]).

        //Examine the limitation of the foreach statement
        //string[] names = { "Alex", "Eddie", "David", "Michael" };
        //foreach (var name in names)
        //{
        //    // Can't do this:
        //    if (name == "David") name = "Sammy";
        //}

        //Overcoming the limitation of the foreach statement using the for statement
        //Curly braces removed for code blocks with a single line of code
        //string[] names = { "Alex", "Eddie", "David", "Michael" };
        //for (int i = 0; i < names.Length; i++)
        //    if (names[i] == "David") names[i] = "Sammy";

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

        //foreach (var name in names) Console.WriteLine(name);
        //Since the array isn't directly part of the iteration statement's implementation, you can change values inside of the array.
    }
}
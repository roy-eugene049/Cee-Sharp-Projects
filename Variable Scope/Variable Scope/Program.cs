using System;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        int first = 1;
         if (first > 0)
        {
            int second = 8;
            sumBoth = first + second;
            first += sumBoth;
        }
        Console.WriteLine(first);

        //normal syntax
        //bool flag = true;
        //if (flag)
        //{
        //    Console.WriteLine(flag);
        //}

        ////single line form if statements
        //bool flag = true;
        //if (flag) Console.WriteLine(flag);


        //larger if elseif else constructs
        //string name = "steve";
        //if (name == "bob") Console.WriteLine("Found Bob");
        //else if (name == "steve") Console.WriteLine("Found Steve");
        //else Console.WriteLine("Found Chuck");

        //formatted and well indented for readability
        //string name = "steve";

        //if (name == "bob")
        //    Console.WriteLine("Found Bob");
        //else if (name == "steve")
        //    Console.WriteLine("Found Steve");
        //else
        //    Console.WriteLine("Found Chuck");


        //important nuggets
        //If you realize you have only one line of code listed within the code blocks of an if-elseif -else statement, you can remove the curly braces of the code block and white space.Microsoft recommends that curly braces be used consistently for all of the code blocks of an if-elseif -else statement(either present or removed consistently).
        //Only remove the curly braces of a code block when it makes the code more readable.It's always acceptable to include curly braces.
        //Only remove the line feed if it makes the code more readable.Microsoft suggests that your code will be more readable when each statement is placed on its own code line.
    }
}
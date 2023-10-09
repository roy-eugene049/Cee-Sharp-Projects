using System;

class Program
{
    static void Main()
    {
        //normal syntax
        //bool flag = true;
        //if (flag)
        //{
        //    Console.WriteLine(flag);
        //}

        ////single line form if statements
        //bool flag = true;
        //if (flag) Console.WriteLine(flag);


        //larger id elseif else constructs
        string name = "steve";
        if (name == "bob") Console.WriteLine("Found Bob");
        else if (name == "steve") Console.WriteLine("Found Steve");
        else Console.WriteLine("Found Chuck");
    }
}
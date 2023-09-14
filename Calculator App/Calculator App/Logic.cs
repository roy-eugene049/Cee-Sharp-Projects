using System;

class Logic
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Basic Calculator");
        Console.WriteLine("----------------");

        while (true)
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = calculator.Add(num1, num2);
                    break;
                case "-":
                    result = calculator.Substract(num1, num2);
                    break;
                case "*":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "/":
                    result = calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please try again.");
                    continue;
            }

            Console.WriteLine($"Result: {result}");

            Console.Write("Do you want to perform another calculation? (Y/N): ");
            string continueCalculation = Console.ReadLine();
            if (continueCalculation.ToUpper() != "Y")
                break;
        }
    }
}
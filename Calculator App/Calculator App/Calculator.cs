public class Calculator
{
    public double Add(double num1, double num2)
    { 
        return num1 + num2; 
    }

    public double Substract(double num1, double num2) 
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2) 
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2) 
    {
        if (num2 == 0) 
        {
            Console.WriteLine("Error: Division by zero!");
            return 0;
        }
        return num1 / num2;
    }
}
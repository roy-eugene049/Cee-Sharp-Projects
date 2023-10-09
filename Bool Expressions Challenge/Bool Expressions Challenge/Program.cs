using System;

class Program
{
    static void Main()
    {
        string permission = "Admin|Manager";
        int level = 55;

        switch (permission)
        {
            case var _ when permission.Contains("Admin") && level > 55:
                Console.WriteLine("Welcome, Super Admin user.");
                break;

            case var _ when permission.Contains("Admin") && level <= 55:
                Console.WriteLine("Welcome, Admin user.");
                break;

            case var _ when permission.Contains("Manager") && level >= 20:
                Console.WriteLine("Contact an Admin for access.");
                break;

            case var _ when permission.Contains("Manager") && level < 20:
                Console.WriteLine("You do not have sufficient privileges.");
                break;

            default:
                Console.WriteLine("You do not have sufficient privileges.");
                break;
        }
    }
}
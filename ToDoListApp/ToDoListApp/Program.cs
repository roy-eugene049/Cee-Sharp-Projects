using System;

class Program
{
    static void Main(string[] args)
    {
        ToDoList toDoList = new ToDoList();

        while (true)
        {
            Console.WriteLine("To-Do List:");
            toDoList.ListTasks();

            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Delete Task");
            Console.WriteLine("3. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();
                    toDoList.AddTask(description);
                    break;

                case "2":
                    Console.Write("Enter task index to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        toDoList.DeleteTask(index - 1);
                    }
                    break;

                case "3":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

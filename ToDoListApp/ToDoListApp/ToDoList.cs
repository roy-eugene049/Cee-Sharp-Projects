using System;
using System.Collections.Generic;

public class ToDoList
{
    private List<TaskItem> tasks= new List<TaskItem>();

    public void AddTask(string description)
    {
        TaskItem task= new TaskItem() { Description = description, IsCompleted = false};
        tasks.Add(task);
    }

    public void DeleteTask(int index)
    {
        if (index >= 0 && index < tasks.Count) 
        {
            tasks.RemoveAt(index);
        }
    }

    public void ListTasks()
    {
        for (int i = 0; i < tasks.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {(tasks[i].IsCompleted ? "[X]" : "[ ]")} {tasks[i].Description}");
        }

        List<String> list = test0();
    }

    private List<String> test0()
    {
        return new List<String>() { "Tester" };
    }
}
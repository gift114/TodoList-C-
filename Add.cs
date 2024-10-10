using System.Collections.Generic;
public class Add
{

    private List<string> tasks = new();
    public void AddTask()
    {
        Console.WriteLine("Enter the task you would like to add to the list.");
        string taskAdded = Console.ReadLine()!;

        tasks.Add(taskAdded);
        Console.WriteLine($"Task '{taskAdded}' has been added.");

    }
}

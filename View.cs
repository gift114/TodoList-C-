using System;
using System.Collections.Generic;

public class View
{
    public void ViewTask(List<string> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("The task list is currently empty.");
        }
        else
        {
            Console.WriteLine("The current task list is:");
            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }
}


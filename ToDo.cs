using System.Collections.Generic;

namespace List
{
    public class ToDo
    {
        public static void ToDoList(List<string> tasks) {

            Console.WriteLine("Enter 1 to add task to the list.");
            Console.WriteLine("Enter 2 to remove task to the list.");
            Console.WriteLine("Enter 3 to view list on the task.");
            Console.WriteLine("Enter 4 to exist the program.");

            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Add add = new();
                    add.AddTask();
                case 2:
                    Remove remove = new();
                    remove.RemoveTask(tasks);
                case 3:
                    View view = new();
                    view.ViewTask(tasks);
                case 4:
                    Console.WriteLine("Existing the program");
            }
        }
    }
}

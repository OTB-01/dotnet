// this app is a simple todo list
// it will ask the user for a task and add it to a String list called tasks
// and display current tasks in the list

List<string> tasks = new List<string>();


while (true)
{
    var choice = "null";

    System.Console.WriteLine("\nWhat would you like to do?");

    DisplayOptions();


    choice = System.Console.ReadLine();
    ProccessChoice(choice, tasks);
}

void DisplayOptions()
{
    System.Console.WriteLine("a. Add task");
    System.Console.WriteLine("b. Remove task");
    System.Console.WriteLine("c. Display all task");
    System.Console.WriteLine("e. Exit");
    System.Console.WriteLine("\n");
}

void ProccessChoice(string choice, List<string> tasks)
{
    switch (choice)
    {
        case "a":
            System.Console.WriteLine("\nEnter task: ");
            tasks.Add(Console.ReadLine());
            break;

        case "b":
            System.Console.WriteLine("\nEnter task to remove: ");
            tasks.Remove(Console.ReadLine());
            break;

        case "c":
            foreach (string task in tasks)
            {
                System.Console.WriteLine(task);
            }
            break;

        case "e":
            System.Console.WriteLine("\nGoodbye!");
            System.Environment.Exit(0);
            break;

        default:
            System.Console.WriteLine("\nInvalid choice");
            break;
    }
}

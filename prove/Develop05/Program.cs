using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");

            Console.Write("Menu Options: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Select from the Menu:");
                    Console.WriteLine("a. Simple Goal");
                    Console.WriteLine("b. Eternal Goal");
                    Console.WriteLine("c. Checklist Goal");

                    Console.Write("The type of Goals are: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "a":
                            Console.Write("Enter goal name: ");
                            string simpleName = Console.ReadLine();
                            Console.Write("Enter goal description: ");
                            string description = Console.ReadLine();
                            Console.Write("Enter goal points: ");
                            int points = Convert.ToInt32(Console.ReadLine());
                            goals.Add(new SimpleGoal(simpleName, description, points));
                            break;
                        case "b":
                            Console.Write("Enter goal name: ");
                            string eternalName = Console.ReadLine();
                            goals.Add(new EternalGoal(eternalName, "Eternal goal", 100));
                            break;
                        case "c":
                            Console.Write("Enter goal name: ");
                            string checklistName = Console.ReadLine();
                            goals.Add(new ChecklistGoal(checklistName, "Checklist goal", 50, 10));
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select again.");
                            break;
                    }
                    break;

                case "2":
                    foreach (var goal in goals)
                    {
                        Console.WriteLine($"{goal.Name} - {goal.Description} - {goal.Points} points");
                    }
                    break;

                case "3":
                    foreach (var goal in goals)
                    {
                        goal.SaveGoals();
                    }
                    break;

                case "4":
                    foreach (var goal in goals)
                    {
                        goal.LoadGoals();
                    }
                    break;

                case "5":
                    foreach (var goal in goals)
                    {
                        goal.RecordEvent();
                    }
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}
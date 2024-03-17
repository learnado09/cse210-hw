using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a new List of Goal objects
        List<Goal> goals = new List<Goal>();

        // Start an infinite loop to display the menu continuously
        while (true)
        {
            // Display the main menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");

            // Prompt the user to select a menu option
            Console.Write("Menu Options: ");
            string option = Console.ReadLine();

            // Process the selected menu option
            switch (option)
            {
                case "1": // Create New Goal
                    // Display goal types
                    Console.WriteLine("Select from the Menu:");
                    Console.WriteLine("a. Simple Goal");
                    Console.WriteLine("b. Eternal Goal");
                    Console.WriteLine("c. Checklist Goal");

                    // Prompt the user to select a goal type
                    Console.Write("The type of Goals are: ");
                    string choice = Console.ReadLine();

                    // Process the selected goal type
                    switch (choice)
                    {
                        case "a": // Simple Goal
                            // Collect goal details from the user
                            Console.Write("Enter goal name: ");
                            string simpleName = Console.ReadLine();
                            Console.Write("Enter goal description: ");
                            string description = Console.ReadLine();
                            Console.Write("Enter goal points: ");
                            int points = Convert.ToInt32(Console.ReadLine());
                            // Create a new SimpleGoal and add it to the goals list
                            goals.Add(new SimpleGoal(simpleName, description, points));
                            break;
                        case "b": // Eternal Goal
                            // Collect goal name from the user
                            Console.Write("Enter goal name: ");
                            string eternalName = Console.ReadLine();
                            // Create a new EternalGoal and add it to the goals list
                            goals.Add(new EternalGoal(eternalName, "Eternal goal", 100));
                            break;
                        case "c": // Checklist Goal
                            // Collect goal name from the user
                            Console.Write("Enter goal name: ");
                            string checklistName = Console.ReadLine();
                            // Create a new ChecklistGoal and add it to the goals list
                            goals.Add(new ChecklistGoal(checklistName, "Checklist goal", 50, 10));
                            break;
                        default:
                            // Handle invalid goal type selection
                            Console.WriteLine("Invalid choice. Please select again.");
                            break;
                    }
                    break;

                case "2": // List Goals
                    // Loop through each goal in the goals list and display its details
                    foreach (var goal in goals)
                    {
                        Console.WriteLine($"{goal.Name} - {goal.Description} - {goal.Points} points");
                    }
                    break;

                case "3": // Save Goals
                    // Loop through each goal in the goals list and save it
                    foreach (var goal in goals)
                    {
                        goal.SaveGoals();
                    }
                    break;

                case "4": // Load Goals
                    // Loop through each goal in the goals list and load it
                    foreach (var goal in goals)
                    {
                        goal.LoadGoals();
                    }
                    break;

                case "5": // Record Events
                    // Loop through each goal in the goals list and record an event
                    foreach (var goal in goals)
                    {
                        goal.RecordEvent();
                    }
                    break;

                case "6": // Quit
                    // Display goodbye message and exit the application
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    // Handle invalid menu option selection
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}

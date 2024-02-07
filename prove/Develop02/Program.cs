using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool keepGoing = true;
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rnd = new Random();

        while (keepGoing)
        {
            Console.Clear();
            int choice = ShowMenu();

            if (choice == 1) // Add journal 
            {
                int promptIndex = rnd.Next(prompts.Length); // Selecting a random prompt
                journal.AddJournal(prompts[promptIndex]); // Passing the selected prompt
            }
            else if (choice == 2) // List journal 
            {
                Console.Clear();
                journal.DisplayJournal();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            else if (choice == 3) // Save journal 
            {
                var lines = journal.Export();
                WriteFile(lines);
            }
            else if (choice == 4) // Load journal 
            {
                var lines = ReadFile();
                journal = new Journal(lines);
            }
            else if (choice == 5) // Exit
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again...");
                Console.ReadKey();
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal");
        Console.WriteLine("4. Load the journal");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Please enter a valid number.");
            return 0; // Returning 0 to handle invalid input gracefully
        }
        return choice;
    }

    static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        File.WriteAllLines(filename, lines);
    }
}


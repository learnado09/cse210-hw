using System;
using System.Threading;

namespace MindfulActivities
{
    abstract class Activity
    {
        protected string name;
        protected string description;
        protected int duration;

        public Activity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Start()
        {
            Console.WriteLine($"\n{name}");
            Console.WriteLine(description);

            while (true)
            {
                Console.Write("\nEnter the duration in seconds (minimum 10 seconds): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out duration) && duration >= 10)
                {
                    break;
                }
            }

            Console.WriteLine("\nGet ready to begin in:");
            CountDown(3);
            RunActivity();
            Console.WriteLine($"\nGreat job! You have completed the {name} activity for {duration} seconds.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }

        protected abstract void RunActivity();

        protected void Pause(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        protected void CountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Go!");
        }
    }


class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you felt truly happy.",
        "Reflect on a moment when you overcame a significant challenge.",
        "Consider a situation where you helped someone and made a difference.",
        "Recall a moment of significant personal growth."
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on meaningful moments in your life, fostering a sense of gratitude and self-awareness.") { }

    protected override void RunActivity()
    {
        int promptIndex = new Random().Next(prompts.Length);
        Console.WriteLine("Prompt: " + prompts[promptIndex]);
        Console.WriteLine("\nTake a moment to reflect on this question. When you're ready, press any key to continue...");
        Console.ReadKey(true);
         reflection activity without interactive components beyond initial reflection.
        Console.WriteLine("Reflection is a powerful tool for personal growth. Remember to take time regularly to reflect on your experiences and feelings.");
    }
}

    class BreathingActivity : Activity
    {
// public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

        protected override void RunActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                Pause(2);
                Console.WriteLine("Breathe out...");
                Pause(2);
            }
        }
    }

    class ListingActivity : Activity
    {
        private string[] prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

        protected override void RunActivity()
        {
            int promptIndex = new Random().Next(prompts.Length);
            Console.WriteLine("Prompt: " + prompts[promptIndex]);
            Pause(5); // Assuming a brief pause before starting
            Console.WriteLine("Begin listing...");
            int count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (string.IsNullOrEmpty(item)) continue;
                count++;
            }
            Console.WriteLine($"You listed {count} items.");
        }
    }

    // Example of ReflectionActivity implementation
    // Ensure to implement this class based on your specific requirements

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mindful Activities!");

            while (true)
            {
                Console.WriteLine("\nPlease select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Quit");

                int choice = 0;
                while (choice < 1 || choice > 4)
                {
                    Console.Write("Enter your choice: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out choice))
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 4.");
                    }
                }

                switch (choice)
                {
                    case 1:
                        var breathing = new BreathingActivity();
                        breathing.Start();
                        break;
                    case 2:
    var reflection = new ReflectionActivity();
    reflection.Start();
    break;

                    case 3:
                        var listing = new ListingActivity();
                        listing.Start();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using Mindful Activities!");
                        return;
                }
            }
        }
    }
}

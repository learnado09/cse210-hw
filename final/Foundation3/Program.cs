using System;

class Program
{
    static void Main(string[] args)
    
       
    {
       // Create objects of each events
        Lecture lectureEvent = new Lecture("Encapsulation", "Principles of incapsulation and their applications", DateTime.Now, new TimeSpan(12, 45, 0),
            new Address { Street = "206 Main St", City = "Rexburg", State = "Idaho", ZipCode = "83440" }, "Tim Thayne", 50);

        Reception receptionEvent = new Reception("Wedding", "Wedding of Mr. David and Mis. Hannah", DateTime.Now, new TimeSpan(18, 0, 0),
            new Address { Street = "103 Newyork St", City = "Redlands", State = "CA", ZipCode = "92373" }, "rsvp@example.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Veterans Day", "Participating in parade and BBq", DateTime.Now, new TimeSpan(12, 0, 0),
            new Address { Street = "Pioneers Rd.", City = "Rexburg", State = "Idaho", ZipCode = "83440" }, "Sunny");

        // Display messages
        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\n");

        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\n");

        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\n");

        Console.WriteLine("Full Details:\n");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\n");

        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\n");

        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\n");

        Console.WriteLine("Short Descriptions:\n");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
    

    

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        activities.Add(new Running(new DateTime(2024, 04, 3), 30, 3.0)); // 3.0 miles
        activities.Add(new Running(new DateTime(2024, 04, 3), 30, 4.8)); // 4.8 km
        activities.Add(new Cycling(new DateTime(2024, 04, 4), 45, 15.0)); // 15.0 mph
        activities.Add(new Cycling(new DateTime(2024, 04, 4), 45, 24.1)); // 24.1 kph
        activities.Add(new Swimming(new DateTime(2024, 04, 5), 60, 40)); // 40 laps

        // Output summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
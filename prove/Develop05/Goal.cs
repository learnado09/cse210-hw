using System;
using System.IO;
using System.Collections.Generic;

public class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"{Name} goal recorded. +{Points} points");
    }

    public virtual void SaveGoals()
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine($"{Name},{Description},{Points}");
        }
    }

    public virtual void LoadGoals()
    {
        string fileName = "myFile.txt";

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string name = parts[0];
                string description = parts[1];
                int points = Convert.ToInt32(parts[2]);

                Console.WriteLine($"Loaded goal: {name}, {description}, {points} points");
            }
        }
        else
        {
            Console.WriteLine("No goals found.");
        }
    }
}
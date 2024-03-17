using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("Eternal goal is Recorded.");
    }
}
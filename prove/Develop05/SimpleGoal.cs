using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("Goal is Completed");
    }
}
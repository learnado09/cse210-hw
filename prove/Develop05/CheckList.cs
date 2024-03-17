using System;
using System.Collections.Generic;
public class ChecklistGoal : Goal
{
    private int planCount;
    private int completedCount;

    public ChecklistGoal(string name, string description, int points, int targetCount) : base(name, description, points)
    {
        this.planCount = targetCount;
        this.completedCount = 0;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        completedCount++;

        Console.WriteLine($"Goal completed {completedCount}/{planCount} times");

        if (completedCount == planCount)
        {
            Console.WriteLine($"Bonus! +{Points} points for completing {planCount} times!");
        }
    }
}

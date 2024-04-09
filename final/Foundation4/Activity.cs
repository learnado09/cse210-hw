using System;
using System.Collections.Generic;

// Base class
public class Activity
{
    protected DateTime _date;
    protected int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
            _date = date;
            _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

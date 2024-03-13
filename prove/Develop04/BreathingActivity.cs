using System;

public class BreathingActivity : Activity
{
    private int _breathInSeconds;
    private int _breatheOutSeconds;

    // Corrected the constructor name to match the class name and removed unnecessary prefix underscores from parameters to adhere to convention
    public BreathingActivity(int duration, string description, string activityName, int initialPauseDuration, int finalPauseDuration, string endingMessage, int breathIn, int breathOut)
        : base(duration, description, activityName, initialPauseDuration, finalPauseDuration, endingMessage)
    {
        _breathInSeconds = breathIn;
        _breatheOutSeconds = breathOut;
    }

    public void StartBreathingActivity()
    {
        StartActivity(_activityName, _description);

        int breathCount = _duration / (_breathInSeconds + _breatheOutSeconds);
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        InitialPause();
        for (int i = 0; i < breathCount; i++)
        {
            Console.WriteLine("Breath in...");
            Countdown(_breathInSeconds);
            Console.WriteLine("Breath out...");
            Countdown(_breatheOutSeconds);
        }
        DisplayEndingMessage(_activityName);
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000); // Pauses for a second
        }
        Console.WriteLine();
    }
}

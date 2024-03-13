public class ListingActivity : Activity
{
    private List<string> _promptsList = new List<string>(); 
    public List<string> _responsesList =new List<string>();

    public ListingActivity(int _duration, string _description, string _activityName, int _initialPauseDuration, int _finalPauseDuration, string _endingMessage) : base(_duration, _description, _activityName, _initialPauseDuration, _finalPauseDuration, _endingMessage)
    {   
        
        _promptsList.Add("Who are people that you appreciate?");
        _promptsList.Add("What are personal strengths of yours?");
        _promptsList.Add("Who are people that you have helped this week?");
        _promptsList.Add("When have you felt the Holy Ghost this month?");
        _promptsList.Add("Who are some of your personal heroes?");
        
    
    }
    public void StartListingActivity(){
        StartActivity(_activityName, _description );
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        InitialPause();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Random random = new Random();
        int randomIndex = random.Next(_promptsList.Count);
        Console.WriteLine(_promptsList[randomIndex]);
        _promptsList.RemoveAt(randomIndex);
        InitialPause();
        Console.WriteLine("You may begin in:");
        Countdown(_initialPauseDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        

        while  (DateTime.Now < endTime){
            Console.Write(">");
            _responsesList.Add(Console.ReadLine());
        }
        int lenghtListedItems = _responsesList.Count;
        Console.WriteLine($"You listed {lenghtListedItems} items!");
        Console.WriteLine();
        DisplayEndingMessage(_activityName);
        

    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}


class Journal
{
    private List<Entry> entries = new List<Entry>();

    public Journal()
    {
    }

    public Journal(string[] loadedEntries)
    {
        foreach (var entry in loadedEntries)
        {
            var parts = entry.Split(new string[] { " - " }, StringSplitOptions.None);
            if (parts.Length >= 3)
            {
                entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
            }
        }
    }

    public void AddJournal(string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public string[] Export()
    {
        return entries.ConvertAll(entry => entry.ToString()).ToArray();
    }
}



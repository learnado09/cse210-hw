
public class Verse
{
    public string Reference { get; private set; }
    public string Text { get; private set; }

    public Verse(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public string GetDisplayText()
    {
        return $"{Reference}: {Text}";
    }
}



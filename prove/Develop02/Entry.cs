public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        //_date = theCurrentTime.ToString("yyyy-MM-dd");
        _date = theCurrentTime.ToShortDateString();
        
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();
        _entryText = "";
        
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");
    }
}
public class Entry 
//represents a single journal entry
{
    //saves response, prompt, and date
    public string _date;
    public string _promptText;
    public string _entryText;

    //behavior
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date: {_date}");

        
        
        Console.WriteLine($"Prompt: {_promptText}");
        

        Console.Write($"{_entryText}"); 
        
        Console.WriteLine("");
    }

}
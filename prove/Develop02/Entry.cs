using System;

public class Entry //NEEDS WORK
//represents a single journal entry
{
    
    public string _date;
    public string _promptText;
    public string _entryText;


    
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        _date = "{theCurrentTime}";
        
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }

}
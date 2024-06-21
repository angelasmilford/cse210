using System;
using System.Net;

class Program
{

}

public class Journal
{
    //state
    public List<Entry> _entries = new List<Entry>();

    //behaviors
    public void AddEntry(new Entry) //need parameter
    {
        Console.WriteLine("Please select one of the followint choices: ");
        int response = 0;
        response = int.Parse(Console.ReadLine());

        Console.Write("1. Write");
        Console.Write("2. Display");
        Console.Write("3. Load");
        Console.Write("4. Save");
        Console.Write("5. Quit");

        if (response == 1)
        {

        }
        else if (response == 2)
        {

        }
        else if (response == 3)
        {

        }
        else if (response == 4)
        {

        }
        else if (response == 5){

        }
        else
        {
            Console.WriteLine("Please answer the question with a single number from 1-5.");
        }



    }

    public void DisplayAll() //displays all journal entries
    {

    }

    public void SaveToFile(file) //need parameter; saves the journal to a file
    {

    }

    public void LoadFromFile(file) //need parameter; loads the journal from a file
    {

    }
}

public class Entry //saves response, prompt, and date
{
    //state
    public string _date;
    public string _promptText;
    public string _entryText;

    //behavior
    public void Display()
    {

    }

}

public class PromptGenerator
{
    //state
    public List<string> _prompts = new List<string>();

    //behavior
    public string GetRandomPrompt()
    {

    }
}
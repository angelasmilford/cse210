using System;
using System.IO;

public class Journal
//stores a list of journal entries
{
    //state; member variables; attributes
    public List<Entry> _entries = new List<Entry>();

    //behaviors; functions; methods
    public void AddEntry(Entry newEntry) //stores a list of Entry objects
    {
        Console.Write(newEntry + "");
        string answer = Console.ReadLine();
        //date
        _entries.Add(new Entry(_entryText, _promptText, _date));
    }

    public void DisplayAll() //displays all journal entries
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file) //saves the journal to a file
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}~~{entry.answer}");
            }
        }
    }

    public void LoadFromFile(string file) //loads the journal from a file
    {
        Console.Write("What is the filename? ");
        string input = Console.ReadLine();
        fileName = input + ".txt";

        using (StreamReader reader = new StreamReader(fileName))
        {
            string headerLine = reader.ReadLine();

        }
        
    }
}
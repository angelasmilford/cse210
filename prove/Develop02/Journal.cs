using System;
using System.IO;
using System.IO.Enumeration;

public class Journal
//stores a list of journal entries
{
    public List<Entry> _entries = new List<Entry>();

    //NEEDS WORK
    public void AddEntry(Entry newEntry) //stores a list of Entry objects
    {
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayAll() //displays all journal entries
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile() //saves the journal to a file
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine() + ".txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry anEntry in _entries)
            {
                outputFile.WriteLine($"{anEntry._date}~~{anEntry._promptText}");
                outputFile.WriteLine($"{anEntry._entryText}");
            }
        }
    }

    //NEEDS WORK
    public void LoadFromFile() //loads the journal from a file
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine() + ".txt";

        if (File.Exists(filename))
        {
            List<Entry> _entries = new List<Entry>();

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }   
        }
        else
        {
            Console.WriteLine("The file you requested does not exist.");
        }
    }
}
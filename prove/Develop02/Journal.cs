using System;
using System.IO;
using System.IO.Enumeration;

public class Journal
//stores a list of journal entries
{
    public List<Entry> _entries;

    //NEEDS WORK
    public void AddEntry(Entry newEntry) //stores a list of Entry objects
    {
        Console.WriteLine(newEntry + "");
        string answer = Console.ReadLine();
        _entries.Add(new Entry());
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
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine() + ".txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry anEntry in _entries)
            {
                outputFile.WriteLine($"{anEntry._date}~~{anEntry._promptText}");
                outputFile.WriteLine($"{anEntry._entryText}");
            }

            SaveToFile(file); //remove?
        }
    }

    //NEEDS WORK
    public void LoadFromFile(string file) //loads the journal from a file
    {
        Console.WriteLine("What is the filename? ");
        string input = Console.ReadLine();
        file = input + ".txt";

        if (File.Exists(file))
        {
            List<Entry> _entries = new List<Entry>();

            string[] lines = System.IO.File.ReadAllLines(file);

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
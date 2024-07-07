using System;
using System.IO;
using System.Net.Mime;

public class Journal
{
    public List<Entry> _entries;


    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine(newEntry._promptText);
        newEntry._entryText = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the name of your file? ");
        string filename = Console.ReadLine() + ".txt";

        using (StreamWriter writer = new StreamWriter(file, true))
        {
            writer.WriteLine(filename);
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("What is the name of your file? ");
        string filename = Console.ReadLine() + ".txt";

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                Console.Write(line);
            }
        }
        else
        {
            Console.WriteLine("The file you requested does not exist: " + file);
        }
        
    }
}
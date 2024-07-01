using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry =  new Entry();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: "); 
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
             
            if (answer == "1")
            {
                theJournal.AddEntry(anEntry);
                anEntry._entryText = Console.ReadLine();
                return;
            }
            else if (answer == "2")
            {
                theJournal.DisplayAll();
                continue;
            }
            else if (answer == "3")
            {
                theJournal.LoadFromFile();
                continue;
            }
            else if (answer == "4")
            {
                theJournal.SaveToFile();
                continue;
            }
            else if (answer ==  "5")
            {
                break;
            }
            else
            {
                Console.Write("Please answer with a single from the 1-5.");
            }

        }
    }
}
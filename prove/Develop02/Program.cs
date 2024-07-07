using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry =  new Entry();

        Console.WriteLine("Welcome to the Journal Program!");

        string file = @"C:\Users\angel\Documents\cse210-hw\prove\Develop02\Develop02.csproj";

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    theJournal.AddEntry(anEntry);
                    anEntry._entryText = Console.ReadLine();
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    theJournal.SaveToFile(file);
                    break;
                case "4":
                    theJournal.LoadFromFile(file);
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Please response with a single from the 1-5.");
                    break;
            }
        }
        
    }
}
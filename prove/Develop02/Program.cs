using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //instance 
        Journal theJournal = new Journal(); //Journal instance
        Entry anEntry = new Entry(); //Entry instance

        //info
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        //initializing value
        int answer = 0;

        Console.WriteLine("What would you like to do? ");
        string response = Console.ReadLine();

        //behavior; function; method
        while(answer != 5)
        {
            
            answer = int.Parse(response);
            //answer = int.Parse(Console.ReadLine());

            //if statement
            if (answer == 1) //Write (NEEDS WORK)
            {
                theJournal.AddEntry(anEntry);
                //prompt
                anEntry.Display();
                anEntry._entryText = Console.ReadLine();   
            }
            
            else if (answer == 2) //Display (NEEDS WORK)
            {
                
                anEntry.Display(); //displays a single journal entry
                theJournal.DisplayAll(); //displays all journal entries
            }
            
            else if (answer == 3) //Load (NEEDS WORK)
            {
                theJournal.LoadFromFile(response); 
            }
            
            else if (answer == 4) //Save (NEEDS WORK)
            {   
                theJournal.SaveToFile(response);
            }
            
            else if (answer == 5) //Quit
            {   
                break;
            }
            
            else
            {
                Console.WriteLine("Please answer with a single number from 1-5.");
            }
        }

    }
}   
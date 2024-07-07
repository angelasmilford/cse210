using System;
using System.Net.Quic;
using mindfullness;

class Program
{
    static void Main(string[] args)
    {
        string option;

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        Console.WriteLine("Select a choice from the menu: ");
        option = Console.ReadLine();
        
        switch (option)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                break;
            case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                break;
            case "4":
                break;
                default:
                Console.WriteLine("Please answer with a single number ranging from 1-4.");
                break;
        }
    }                                                   
}
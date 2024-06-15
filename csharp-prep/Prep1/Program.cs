using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask for first name
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        //Ask for last name
        Console.Write("What is your last name? ");
        string surname = Console.ReadLine();

        //Print first and last name
        Console.WriteLine("");
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}
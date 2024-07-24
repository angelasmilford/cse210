//EVENT PLANNING

using System;

class Program
{
    static void Main(string[] args)
    {
        var lectureAddress = new Address("139 Kane Street", "Gotham City", "NY", "USA");
        Address receptionAddress = new Address("Jump City Bay", "Jump City", "CA", "USA");
        Address outdoorAddress = new Address("75 Park Avenue", "Aegean Sea", "Paradise Island", "Themyscira");

        // creates at least one event of each type and sets all of their values
        Lecture lecture = new Lecture("Artificial Intelligence", "A lecture on Artificial Intelligence that's held in the hall of Wayne Manor for undergraduate students of Gotham City University.", DateTime.Now, lectureAddress, "Bruce Wayne", 40);
        Reception reception = new Reception("Graduation Reception", "An occasion to celebrate the high school graduation of the Teen Titans.", DateTime.Now.AddDays(45), receptionAddress, "teentitans@email.com");
        Outdoor outdoor = new Outdoor("Amazon Games", "A series of athletic challenges held to honor Amazon's best.", DateTime.Now.AddDays(50), outdoorAddress, "Sunny with a high of 81°F (27°C) and a low of 67°F (19°C). 0% chance of rain.");
        
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();
    }
}
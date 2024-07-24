using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Angela", "Samoa History");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Suria", "Algebra", "56", "1-20");
        Console.Write(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Jayden", "Fiji", "Culture");
        Console.Write(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());

        Assignment assignment3 = new Assignment("Ian", "Fraction");
        Console.WriteLine(assignment3.GetSummary());
    }
}
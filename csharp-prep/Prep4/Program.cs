using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //assignment
        List<int> numbers = new List<int>();
        
        int userNumber = 0;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
            
        //average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //largest number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        //have the user enter both positive and negative numbers, then find the smallest positive number closest to zero
        

        //sort the numbers in the list and display the new, sorted list
        List<int>sortedNumber = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"The sorted list is: {i}");
        }
    }
}
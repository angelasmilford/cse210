using System;

using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        
        //ask the user for their grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);
        
        if (number >= 90)
        {
            //letter
            string letter = "A";
            if (number >= 93 && number <= 100)
            {
                letter = "A";
            }
            else if (number >= 90 && number < 93)
            {
                letter = "A-";
            }

            //printing grade
            Console.WriteLine($"Your grade is an {letter}.");
            
            //passing grade
            if (number >= 70)
            {
                Console.WriteLine("Congratulations! You passed this class.");
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not pass this class, but don't let this stop you. Keep going and keep working hard. I believe in you.");
            }
            
        }
        else if (number >= 80)
        {
            //letter
            string letter = "B";
            if (number >= 87 && number <= 89)
            {
                letter = "B+";
            }
            else if (number >= 83 && number <= 86)
            {
                letter = "B";
            }
            else if (number >= 80 && number < 83)
            {
                letter = "B-";
            }
            
            //print the grade
            Console.WriteLine($"Your grade is a {letter}.");
            
            //passing grade
            if (number >= 70)
            {
                Console.WriteLine("Congratulations! You passed this class.");
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not pass this class, but don't let this stop you. Keep going and keep working hard. I believe in you.");
            }
        }
        else if (number >= 70)
        {
            //letter
            string letter = "C";
            if (number >= 77 && number <= 79)
            {
                letter = "C+";
            }
            else if (number >= 73 && number <= 76)
            {
                letter = "C";
            }
            else if (number >= 70 && number < 73)
            {
                letter = "C-";
            }

            //print the grade
            Console.WriteLine($"Your grade is a {letter}.");
            
            //passing grade
            if (number >= 70)
            {
                Console.WriteLine("Congratulations! You passed this class.");
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not pass this class, but don't let this stop you. Keep going and keep working hard. I believe in you.");
            }
        }
        else if (number >= 60)
        {
            //letter
            string letter = "D";
            if (number >= 67 && number <= 69)
            {
                letter = "D+";
            }
            else if (number >= 63 && number <= 66)
            {
                letter = "D";
            }
            else if (number >= 60 && number < 63)
            {
                letter = "D-";
            }

            //print the grade
            Console.WriteLine($"Your grade is a {letter}.");
            
            //passing grade
            if (number >= 70)
            {
                Console.WriteLine("Congratulations! You passed this class.");
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not pass this class, but don't let this stop you. Keep going and keep working hard. I believe in you.");
            }
        }
        else if (number < 60)
        {
            //letter
            string letter = "F";
            if (number >= 0 && number <= 59)
            {
                letter = "F";
            }

            //print the grade
            Console.WriteLine($"Your grade is an {letter}.");
            
            //passing grade
            if (number >= 70)
            {
                Console.WriteLine("Congratulations! You passed this class.");
            }
            else
            {
                Console.WriteLine("Unfortunately, you did not pass this class, but don't let this stop you. Keep going and keep working hard. I believe in you.");
            }
        }
        else
        {
            Console.WriteLine("Please answer the question correctly.");
        }
    }
}
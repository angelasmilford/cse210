using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            //Random Numbers
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            //Ask the user for the magic number
            Console.WriteLine("What is the magic number? ");
            string magicNum = Console.ReadLine();
            
            int guess = 0;

            while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            } 

            //number of guesses
            

            //want to play again?
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
            Console.WriteLine("");
        }  while (response == "yes");

    }
}
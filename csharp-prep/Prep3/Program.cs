using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string n = Console.ReadLine();
        // int number = int.Parse(n);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);

        int guess;

        
        do
        {
        Console.Write("What is your guess? ");
        string g = Console. ReadLine();
        guess = int.Parse(g);

        if (guess < number)
        { 
            Console.WriteLine("Higuer");
        }

        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
            

        } while (guess != number);

        Console.WriteLine("You guessed it!");     

    }
}
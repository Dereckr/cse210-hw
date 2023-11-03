using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string user = PromptUserName();
        int number = promptNumber();
        int square = SquareNumber(number);
        DisplayResult(user,square);
        
        Console.Write("Please enter your favorite number: ");
        


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
            
        }

        static string PromptUserName()
        {
           Console.Write("Please Enter your name: ");
            string user=Console.ReadLine();
            return user;
        }

        static int promptNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string snumber = Console.ReadLine();
            int number = int.Parse(snumber);
            return number;
        }    

        static int SquareNumber(int number)
        {
            int square = number*number;
            return square;
        }

        static void DisplayResult(string user, int square)
        {
            Console.WriteLine($"{user}, the square of your number is {square}");
        }




    }
}


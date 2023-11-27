using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        do {
        Console.WriteLine("Menu Options:");
        Console.WriteLine( "1. Start breathing activity");
        Console.WriteLine( "2. Start reflecting activity");
        Console.WriteLine( "3. Start listing activity");
        Console.WriteLine( "4. Quit");
        Console.Write("Select a choice from the menu: ");
        choice= Console.ReadLine();
        Console.Clear();

        if (choice =="1"){
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();                 
        }

        else if (choice == "2"){

            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.Run();
        }

        else if (choice == "3"){
            ListingActivity listing = new ListingActivity();
            listing.Run();
        }

        } while (choice != "4");



    }
    
}
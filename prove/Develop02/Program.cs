using System;
using System.Threading.Tasks.Dataflow;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        string selectNumber;
        
        Journal myJournal = new Journal();

        do
        {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        selectNumber = Console.ReadLine();

        if (selectNumber == "1")
        {
            Entry newEntry = new Entry(); 
            myJournal.AddEntry(newEntry);
        }

        else if (selectNumber == "2")
        {
            myJournal.DisplayAll();
        }

        else if (selectNumber == "3")
        {
           Console.WriteLine("What is the file name?");
           string _filename = Console.ReadLine();
           myJournal.LoadFromFile(_filename); 
        }

         else if (selectNumber == "4")
        {                   
            Console.WriteLine("What is the file name?");
            string _filename = Console.ReadLine();
            myJournal.SaveToFile(_filename);
        }

        } while (selectNumber != "5");
    }
}
using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have 2 options");
        Console.WriteLine("1. for 1 verse scripture");
        Console.WriteLine("2. for multiple verse scripture");
        Console.WriteLine("Please input 1 or 2: ");
        string selection = Console.ReadLine();
        Console.Clear();
        
        if (selection=="1"){
            Reference myReference1 = new Reference("Ether", 12, 27);
            Scripture scripture = new Scripture(myReference1,"And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
            string selection1;
            do{
            scripture.GetDisplayWords();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
             selection1 = Console.ReadLine();
            scripture.HideRandomWords();
             Console.Clear();
             } while (selection1 != "quit" || scripture.IsCompletetlyHidden() == true);
           

        }
        else if(selection=="2"){
            Reference myReference2 = new Reference("Moroni",10, 5,6);
            Scripture scripture = new Scripture(myReference2,"And by the power of the Holy Ghost ye may aknow the truth of all things. And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");
            string selection1;
            do{
            scripture.GetDisplayWords();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
             selection1 = Console.ReadLine();
             scripture.HideRandomWords();
             Console.Clear();
             } while (selection1 != "quit" || scripture.IsCompletetlyHidden() == true);
           

        
        }

        



    }
}
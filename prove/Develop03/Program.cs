using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You have 2 options");
        Console.WriteLine("1. for 1 verse scripture");
        Console.WriteLine("2. for multiple verse scripture");
        Console.WriteLine("Please input 1 or 2: ");
        string selection = Console.ReadLine();
        
        if (selection=="1"){
            Reference myReference1 = new Reference("Ether", 12, 27);
            Word myword = new Word("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        }
        else if(selection=="2"){
            Reference myReference2 = new Reference("Moroni",10, 5,6);
            Word myword = new Word("And by the power of the Holy Ghost ye may aknow the truth of all things. And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");
        }

    }
}
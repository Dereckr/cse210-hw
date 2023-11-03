using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();
        
        int number = -100000000;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (number != 0)
        {
        Console.Write("Enter a number: ");
        string snumber = Console.ReadLine();
        number = int.Parse(snumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } 

        int num ;
        int sum = 0;
        int larger = -1000000;

        for (int i = 0; i < numbers.Count; i++)
        {
            num = numbers[i];
            if (num > larger)
            {
                larger = num;
            }
            sum += num ; 
        }

        float average = (float)sum / numbers.Count;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {larger}");

    }
}
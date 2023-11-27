using System;
public class ListingActivity : Activity{
    private int _count= 0;
    List<string> _prompts = new List<string>();

    public ListingActivity(){
    _name = "Listing";
    _description= "This activity will help you reflect on the good things in your life by having you list many things as you can in a certain area";
    _duration=50;
    }

    public string GetRandomPrompt(){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        string prompt = _prompts[number];

        return prompt;
    }

    public void Run(){
        DisplayStartingMessage(_name,_description);
        Console.Write("How long, in seconds, would you like for your session ");
        _duration = int.Parse(Console.ReadLine());

       Console.WriteLine("Get Ready...");
        ShowSpinner(2);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may begin in");
        ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count+=1;
        }
        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage(_name,_duration);
        ShowSpinner(3);
        Console.Clear();
        

    }
}

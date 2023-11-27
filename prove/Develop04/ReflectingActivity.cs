using System;
public class ReflectingActivity : Activity {

    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();
    
    public ReflectingActivity(){
    _name = "Reflecting";
    _description= "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _duration=50;
    }
    public string GetRandomPrompt(){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);
        string _prompt = _prompts[number];
        return _prompt;
    }

    public string GetRandomQuestion(){
        _questions.Add("Why was this experience meaningful to you");
        _questions.Add("Have you ever done anything like this before");
        _questions.Add("How did you get started");
        _questions.Add("How did you feel when this was complete");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 9);
        string question = _questions[number];
        return question;
    }

    public void Run(){
        DisplayStartingMessage(_name,_description);
        Console.WriteLine("Get Ready...");
            ShowSpinner(2);
        Console.Write("How long, in seconds, would you like for your session? Please insert the time in multiples of 10: " );
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        ShowCountDown(3);
        Console.Clear();

         while (DateTime.Now < endTime)
        {
            Console.WriteLine($"{GetRandomQuestion()} "); ShowSpinner(10);
            
        }

        DisplayEndingMessage(_name,_duration);
        ShowSpinner(3);
        Console.Clear();

    }
        
        

}
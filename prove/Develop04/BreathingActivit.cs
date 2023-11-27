using System;
public class BreathingActivity : Activity{
public BreathingActivity(){
    _name = "Breathing";
    _description= "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.";
    _duration=50;
    }

    public void Run(){
        DisplayStartingMessage(_name,_description);
        Console.Write("How long, in seconds, would you like for your session? Please insert the time in multiples of 10: ");
        _duration = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Get Ready...");
            ShowSpinner(2);

         while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in..."); ShowCountDown(5);
            Console.WriteLine("Now breathe out..."); ShowCountDown(5);
        }

        DisplayEndingMessage(_name,_duration);
        ShowSpinner(3);
        Console.Clear();

    }
}
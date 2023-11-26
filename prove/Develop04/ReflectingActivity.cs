using System;
public class ReflectingActivity : Activity {
    public ReflectingActivity(){
    _name = "Reflecting";
    _description= "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _duration=50;
    }

    public void Run(){
        DisplayStartingMessage(_name,_description);
        Console.Write("How long, in seconds, would you like for your session" );
        _duration = int.Parse(Console.ReadLine());
        
        


    }

}
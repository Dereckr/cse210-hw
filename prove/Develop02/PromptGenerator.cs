using System;
using System.Collections.Generic;
using System.IO; 

public class PromptGenerator
{
    public List<string> _prompts = new List<string> ();
   
 
  
 
    public string GetRandomPrompt()
   {
    _prompts.Add("What was the experience that helped you strengthen your testimony that we have a Heavenly Father?");
    _prompts.Add("Who did something admirable today and what that person did?");
    _prompts.Add("What did you feel proud of this day?");
    _prompts.Add("What thing you did today that you think you could have done better?");
    _prompts.Add("Explain what was a thing you thought today that you would like to have or keep in your life in the future:");

    Random randomGenerator = new Random();
    int number = randomGenerator.Next(0, 5);

    string _prompt = _prompts[number];

    return _prompt;

   }
}
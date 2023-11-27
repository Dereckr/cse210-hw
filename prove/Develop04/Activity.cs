using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
public class Activity{ 
protected string _name="";
protected string _description = "";
protected  int _duration;





 public void DisplayStartingMessage(string activityName, string  description)
  {
    Console.WriteLine($"Welcome to the {activityName} Activity.\n{description} ");
 }

   public void DisplayEndingMessage(string activityName, int  duration)
  {
    Console.WriteLine("Well done!!!");
    Console.WriteLine($"You have completed another {duration} seconds of the  {activityName} Activity. ");
 }
  public void ShowSpinner(int seconds){
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
   
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

     while (DateTime.Now < endTime)
    {
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");
        i++;

        if (i >= animationStrings.Count)
        {
            i=0;
        }
    }
  }

  public void ShowCountDown(int seconds){

    while (seconds>= 1){
        Console.Write(seconds);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        seconds-= 1;

    }

  }

}


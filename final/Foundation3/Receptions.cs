using System;

public class Receptions:Event
{
    private string _email;

    public Receptions(string eventTitle, string description, string date, string time , string address, string email) : base(eventTitle, description, date, time , address)
    {
        _email=email;
    }

    public void DisplayFull()
    {
        Console.WriteLine($"{GetStandard()}\nType of event: Reception\nEmail for RSVP: {_email}\n");

    }

    public void DisplayShort()
    {
        Console.WriteLine($"Type of Event: Reception\n{GetTitleandDate()}");
        Console.WriteLine("");

    }



}
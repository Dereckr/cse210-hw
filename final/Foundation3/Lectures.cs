using System;

public class Lectures:Event
{
    private string _speaker;
    private  string _capacity;

    public Lectures(string eventTitle, string description, string date, string time , string address, string speaker, string capacity) : base(eventTitle, description, date, time , address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

        public void DisplayFull()
    {
        Console.WriteLine($"{GetStandard()}\nType of Event: Lecture\nSpeaker Name: {_speaker}\nCapacity: {_capacity}");
        Console.WriteLine("");
    }
        public void DisplayShort()
    {
        Console.WriteLine($"Type of Event: Lecture\n{GetTitleandDate()}");
        Console.WriteLine("");

    }

}
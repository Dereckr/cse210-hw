using System;

public class OutdoorGatherings:Event
{
    private string _weather;

     public OutdoorGatherings(string eventTitle, string description, string date, string time , string address, string weather) : base(eventTitle, description, date, time , address)
     {
        _weather= weather;
     }

         public void DisplayFull()
    {
        Console.WriteLine($"{GetStandard()}\nType of event: Outdoor Gathering\nweather: {_weather}\n");
    }

        public void DisplayShort()
        {
            Console.WriteLine($"Type of Event: Outdoor Gathering\n{GetTitleandDate()}");
        }



}
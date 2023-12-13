using System;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle=eventTitle;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
    }

    public string GetStandard()
    {
       return $"Event Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public string GetTitleandDate()
    {
        return $"Title: {_eventTitle}\nDate: {_date}";
    }


}
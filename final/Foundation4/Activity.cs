public class Activity
{
    private string _date;
    private double _length;
    private string _activity;

    public Activity(string date, double length, string activity)
    {
        _date = date;
        _length = length;
        _activity = activity;
    }

    public virtual double GetDistance()
    {
        return 0;;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public double GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetSummary()
    {
        return $"{_date} {_activity}({GetLength()} min) : Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace()} min per km";
    }





}
using System;
public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, string activity, double distance) : base(date,length,activity)
    {
        _distance=distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 60*_distance/GetLength();
    }

        public override double GetPace()
    {
        return GetLength()/_distance;
    }
}

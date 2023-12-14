using System;
public class Swimming : Activity
{
    private double _numberofLaps;

    public Swimming(string date, double length, string activity, double numberofLaps) : base(date,length,activity)
    {
        _numberofLaps=numberofLaps;
    }

    public override double GetDistance()
    {
        return _numberofLaps*50/1000;
    }

    public override double GetSpeed()
    {
        return GetDistance()/GetLength();
    }


        public override double GetPace()
    {
        return 60/GetSpeed();
    }

}
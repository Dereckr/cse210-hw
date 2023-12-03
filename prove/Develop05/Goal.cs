using System;
using System.Data.SqlTypes;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual string GetDetailsString()
    {
        string details = $"[] {_shortName} ({_description})";
        return details;
    }

    // public abstract bool IsComplete();
    // public abstract string GetStringRepresentation();
    // public abstract void RecordEvent();
   




}
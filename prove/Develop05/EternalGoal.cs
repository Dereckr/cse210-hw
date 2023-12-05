using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) :base(name, description,  points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    } 

      public override string GetStringRepresentation()
    {
        string rep = $"EternalGoal:{_shortName}~~{_description}~~{_points}";
        return rep;
    }

    public override int RecordEventC()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        
        return _points;

    }

}
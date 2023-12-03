using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted = 0;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) :base(name, description,  points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        string details = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        return details;
    }



}
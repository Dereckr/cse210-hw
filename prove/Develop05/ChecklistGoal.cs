using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) :base(name, description,  points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    } 

}
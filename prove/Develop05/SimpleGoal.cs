using System;
using System.Runtime.CompilerServices;
using System.IO; 


public class SimpleGoal : Goal
{
    public bool _IsComplete=false; 
    public SimpleGoal(string name, string description, int points) :base(name, description,  points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override string GetStringRepresentation()
    {
        string rep = $"SimpleGoal:{_shortName}~~{_description}~~{_points}~~{_IsComplete}";
        return rep;
    }
    public override bool IsComplete()
    {
        if (_IsComplete == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    public override void RecordEventC()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _IsComplete = true;
        GoalManager goalscore = new GoalManager();
        Console.WriteLine($"You now have {goalscore.SetScore(_points)}");
        Console.WriteLine("");

    }


}
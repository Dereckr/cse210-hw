using System;
using System.IO; 


public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    public int _amountCompleted = 0;


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
        if (IsComplete()==false)
        {
        string details = $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        return details;
        }
        else 
        {
            string details = $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
            return details;
        }
    }

      public override string GetStringRepresentation()
    {
        string rep = $"ChecklistGoal:{_shortName}~~{_description}~~{_points}~~{_bonus}~~{_target}~~{_amountCompleted}";
        return rep;
    }
        public override bool IsComplete(){
            if (_amountCompleted == _target)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int RecordEventC()
        {
        _amountCompleted+=1;
        if (_amountCompleted == _target)
            {
                _points = _bonus + _points;
            }
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine("");
        return _points;

        }

}

 



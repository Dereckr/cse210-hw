using System;
using System.Data.SqlTypes;

public abstract class Goal
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
        if (IsComplete()==false){
        string details = $"[ ] {_shortName} ({_description})";
        return details;
        }
        else
        {
            string details = $"[X] {_shortName} ({_description})";
            return details;
        }
    }

    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetStringRepresentation()
    {
        string rep = $"";
        return rep;
    }
   
    public abstract int RecordEventC();
    

    public string GetName(){
        string name = $"{_shortName}";
        return name;
    }
   




}
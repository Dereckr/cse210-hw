using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;


public class GoalManager 
{
    List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public void Start(){
        string selection;
        do
        {
            DisplayPlayerScore();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                CreateaGoal();
            }

            else if (selection == "2")
            {
                DisplayPlayerInfo();
            }

            else if (selection == "3")
            {
                Console.WriteLine("What is the file name?");
                string _filename = Console.ReadLine();
                SaveToFile(_filename);
            }

            else if (selection == "4")
            {
                Console.WriteLine("What is the file name?");
                string _filename = Console.ReadLine();
                LoadFromFile(_filename); 
            }

            else if (selection == "5")
            {
                RecordEvent();
            }

        }while (selection != "6");
    }

    public void CreateaGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal ");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simple = new SimpleGoal(name, description,points);
            _goals.Add(simple);
        }

        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }

        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target =  int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
   
    }

    public void DisplayPlayerInfo()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to File...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            { 
               outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading List From File...");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts= line.Split(":");
            GoalManager goaltype = new GoalManager();
            
                if (parts[0] == "SimpleGoal")
                {
                    string[] subParts = parts[1].Split("~~");
                    SimpleGoal loadedSimple = new SimpleGoal(subParts[0],subParts[1],int.Parse(subParts[2]));
                    loadedSimple._IsComplete = bool.Parse(subParts[3]);
                    _goals.Add(loadedSimple);
                } 
                
                else if (parts[0] == "EternalGoal")
                {
                    string[] subParts = parts[1].Split("~~");
                    EternalGoal loadedEternal = new EternalGoal(subParts[0],subParts[1],int.Parse(subParts[2]));
                    _goals.Add(loadedEternal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    string[] subParts = parts[1].Split("~~");
                    ChecklistGoal loadedChecklist = new ChecklistGoal(subParts[0],subParts[1],int.Parse(subParts[2]),int.Parse(subParts[4]),int.Parse(subParts[3]));
                    loadedChecklist._amountCompleted= int.Parse(subParts[5]);
                    _goals.Add(loadedChecklist);
 
                }
                else 
                {
                    _score=int.Parse(parts[0]);
                }
                
      
        }
    }
    
   
    
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach(Goal goals in _goals)
        {
           
            Console.WriteLine($"{goals.GetName()}");
            
        }
        Console.Write("Which goal did you accomplish? Please insert a number being 1 the first option: ");
        string option = Console.ReadLine();
        _goals[int.Parse(option)-1].RecordEventC();
    }

    public int SetScore(int points)
    {
        _score=points+_score;
        return _score;
    }

    public void DisplayPlayerScore()
    {
        Console.WriteLine($"You have {_score} points");
    }

    
}
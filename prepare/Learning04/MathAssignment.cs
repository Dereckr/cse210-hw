using System;
using System.Xml;


public class MathAssignment:Assignment
{
    private string _textbookSection ="";
    private string _problems = "";

    public MathAssignment(string name, string topic, string textbook, string problems) : base(name,topic)    
    {
        _textbookSection = textbook;
        _problems = problems;
    }

    public string GetHomeWorkList(){

        string outputstring = $"{GetSummary()}\nSection {_textbookSection} Problems {_problems}";
        return outputstring;
    }

}
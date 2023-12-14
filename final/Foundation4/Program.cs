using System;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("03 Nov 2023",30,"Running", 4.8);
        Cycling cycling1 = new Cycling("10 Dec 2023",40,"Cycling",20);
        Swimming swimming1 = new Swimming("11 Dec 2023",60,"Swimming",10);

        List<Activity> _activities = new List<Activity>();
        _activities.Add(running1);
        _activities.Add(cycling1);
        _activities.Add(swimming1);

        foreach(Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        } 
    }
}
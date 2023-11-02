using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeN = int.Parse(grade);
        string letterGrade = "no grade was inserted yet";



        if (gradeN >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeN >= 80)
        {
            letterGrade = "B";
        }

        else if (gradeN >= 70)
        {
            letterGrade = "C";
        }

        else if (gradeN >= 60)
        {
            letterGrade = "D";
        }

        else if (gradeN < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter Grade is {letterGrade}");

        if (gradeN >= 70)
        {
            Console.WriteLine("Congratulations");

        }

        else
        {
             Console.WriteLine("You can do it");
        }





        



    }
}
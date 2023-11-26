using System;
public class ListingActivity : Activity{
    public ListingActivity(){
    _name = "Listing";
    _description= "This activity will help you reflect on the good things in your life by having you list many things as you can in a certain area";
    _duration=50;
    }

    public void Run(){
        DisplayStartingMessage(_name,_description);
        Console.Write("How long, in seconds, would you like for your session" );
        _duration = int.Parse(Console.ReadLine());

    }
}

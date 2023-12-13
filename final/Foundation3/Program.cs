using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture1 = new Lectures("Renewable Energies","A explanation of the renewable energies available","March 23th","3:00 PM", "La Florida","Juan Alarcon","100 people");
        Console.WriteLine(lecture1.GetStandard());
        Console.WriteLine("");
        lecture1.DisplayFull();
        lecture1.DisplayShort();


        Receptions reception1 = new Receptions("30 Anniversary prom 2000","Prom Reunion","Dec 23th","7:00 PM","123 Main Street","info@fabulousevents.com" );
        Console.WriteLine(reception1.GetStandard());
        Console.WriteLine("");
        reception1.DisplayFull();
        reception1.DisplayShort();

        OutdoorGatherings outdoor1 =new OutdoorGatherings("Paravicini's Family Reunion","All our family will gather from each corner of the World","February 23rd", "9 AM", "Lincoln Road Avenue #13","Sunny Average Temperature of 23 Degrees Celsius ");
        Console.WriteLine(outdoor1.GetStandard());
        Console.WriteLine("");
        outdoor1.DisplayFull();
        outdoor1.DisplayShort();

    }
}
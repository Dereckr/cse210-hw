using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
  public List<Entry> _entries = new List<Entry>();
  
  public void AddEntry(Entry newEntry)
  {
      PromptGenerator prompt = new PromptGenerator();
      newEntry._promptText = prompt.GetRandomPrompt();
      Console.WriteLine(newEntry._promptText);
      newEntry._entryText=Console.ReadLine();
      DateTime theCurrentTime = DateTime.Now;
      newEntry._date = theCurrentTime.ToShortDateString();
      _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }

  public void SaveToFile(string file)
  {
    Console.WriteLine("Saving to File...");
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      foreach(Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
      }

    }
    
    
  }

  public void LoadFromFile(string file)
  {
    Console.WriteLine("Reading List From File...");
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
      string[] parts= line.Split("~~");

      Entry loadedENtry = new Entry();
      loadedENtry._date = parts[0];
      loadedENtry._promptText = parts[1];
      loadedENtry._entryText = parts[2];
      _entries.Add(loadedENtry);

    }
    


  }

  


}
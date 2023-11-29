using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;


    
    public Scripture(Reference Reference, string text){
        _reference = Reference;
       string[] words=text.Split(" ");
       foreach (string word in words){
         Word word1= new Word(word);
         _words.Add(word1);
       }
    }
    public void HideRandomWords() 
    {   
        
        for (int i =0;i<4;i++) 
        {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _words.Count);
        _words[number].Hide();
        
        }
    }

    public void GetDisplayWords(){
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            word.GetDisplayText();
        }
        Console.WriteLine();
    }

    public bool IsCompletetlyHidden(){
        foreach (Word word in _words) {
            do {
            
                return false;
            } while (word.IsHidden()==false);
        }
        return true;
    }
   
}

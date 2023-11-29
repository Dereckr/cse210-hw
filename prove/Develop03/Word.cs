using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
public class Word {
private string _text ="";
private bool _isHidden;

public Word(string text){
_text = text;
_isHidden = false;
}



public void Hide(){
 _isHidden = true;

}

public void Show(){
 _isHidden = false;
}

public bool IsHidden(){
   
    return _isHidden;
}


public void GetDisplayText(){
    if (_isHidden == false){
        Console.Write($"{_text}");
    }
    else if (_isHidden == true){
        string word= _text.ToString();
        int numberletter = word.Length;
        for (int i=0;i<numberletter;i++)
        Console.Write("_");
    }
    Console.Write(" ");
}

}
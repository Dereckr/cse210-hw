using System;
using System.Runtime.CompilerServices;

public class Shape
{
 private string _color;

public string GetColor()
{
    return _color;
}

public void SetColor(string color)
{
    _color = color;
}
 public Shape(string color)
 {
    _color = color;
 }
 public virtual double GetArea()
 {
    double area=2;
    return area;

 }

}




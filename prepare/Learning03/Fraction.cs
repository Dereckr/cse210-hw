using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

    public string GetFractionString()
    {
        string _fraction = ($"{_top}/{_bottom}");
        return _fraction;
    }

    public double GetDecimalValue()
    {
        double fractiond = (double)_top/_bottom;
        return fractiond;
    }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; 
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string getTop()
    { 
        return _top.ToString();
    }

    public void setTop(int top)
    {
        _top = top;
    }
    
    public string getbottom()
    { 
        return _bottom.ToString();
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

}
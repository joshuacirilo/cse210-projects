using System;
using System.Diagnostics.Contracts;
class Fraction
{
    private int _top;
    private int _bottom;

    //first constructor 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Second constructor 
    public Fraction(int number)
    {
        _top = number;
        _bottom =1; 
    }

    //third constructor 

    public Fraction(int numberTop, int numberBottom)
    {
        _top = numberTop;
        _bottom = numberBottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top/(double)_bottom;

        return decimalValue;
    }





}
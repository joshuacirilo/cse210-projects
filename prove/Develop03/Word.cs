using System;
using System.Reflection.Metadata;

class Word
{
    private string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }


    public string GetDisplayText()
    {


        if (_isHidden)
        {
            return "___";
        }
        else
        {
            return _text;
        }

    }





}
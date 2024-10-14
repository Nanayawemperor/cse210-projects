using System;
class Word
{
    private string _text;


    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {

    }
    public void Show()
    {
        Console.WriteLine();
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
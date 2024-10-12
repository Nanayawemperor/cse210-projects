using System;
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        Console.Clear();
        Console.Write("________");
        Console.ReadLine();
    }
    public void Show()
    {
        Console.WriteLine();
    }
    public bool Ishidden()
    {
        return true;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}
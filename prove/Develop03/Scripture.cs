using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        List<Word> words = new List<Word>();
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide > 0)
        {
            Console.Clear();
        }

    }
    public string GetDisplayText()
    {
        return " ";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}
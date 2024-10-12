using System;
using System.ComponentModel;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture()
    {
        
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = Word.Word.Word(text);

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return _reference + " " + _words;  
    }


}
using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Reference
{
    private string _book = "John";
    private int _chapter = 11;
    private int _verse = 35;
    private int _endVerse = 36;

    public Reference(string book,int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
        
        public string GetDisplayText()
        {
            return _book + " " + _chapter + " " + _verse + "-" + _endVerse ;
        }
}  

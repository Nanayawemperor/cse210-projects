class _Reference
{
    //variables in this class
    //_book : string
    //_chapter : int
    //_verse : int
    //_endVerse : int
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

     public void Reference(string book, int chapter, int verse)
     {
        Console.WriteLine(book,chapter,verse);
     }

     public void Reference(string book, int chapter,int startVerse, int endVerse)
     {
        Console.WriteLine(book,chapter,startVerse,endVerse);
     }

     private string GetDisplayText()
     {
        return _book + "" + _chapter + "" + _verse;
     }

}
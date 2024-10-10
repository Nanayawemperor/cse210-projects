public class Word
{
    //variables in this class
    //_text : string
    //_isHidden : bool
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
     Console.WriteLine(text);
    }

    public void Hide()
    {
        Console.Clear();
    }

    public void Show()
    {
    Console.WriteLine();
    Console.ReadLine();
    }

    public void IsHidden()
    {
        Console.Clear();
    }

}
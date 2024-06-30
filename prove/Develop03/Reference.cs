public class Reference
{
    //state
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;


    //behavior
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse) //if scripture has more than 1 verse
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_startVerse} {_endVerse}";
        }
    }

    //Getters and Setters
    public string GetBook()
    {
        return _book;
    }
    public void SetBook()
    {
        _book = book;
    }

    public int GetChapter()
    {
        return _chapter;
    }
    public void SetChapter()
    {
        _chapter = chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }
    public void SetVerse()
    {
        _verse = verse;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }
    public void SetStartVerse()
    {
        _startVerse = startVerse;
    }

    public int GetEndVerse()
    {   
        return _endVerse;
    }
    public void SetEndVerse()
    {
        _endVerse = endVerse;
    }
}
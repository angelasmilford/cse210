public class Word
{
    //state
    private string _text;
    private bool _isHidden;


    //behavior
    public Word(string text)
    {
        _text = text;
        _isHidden = false; 
    }

    public void Hide() //hides a word
    {   
        _isHidden = true;
    }
    public void Show() //shows a word
    {
        _isHidden = false;

        _text = text;
        Console.Clear();

        Console.WriteLine($"{_text}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new String('_', len);
            if (_hidden.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
        }
    }
    public bool IsHidden() //checks to see if a word is hidden
    {
        //get;
        //set;
        return _isHidden;
    }
    public string GetDisplayText() //displays the text
    {
        return _text;
    }
}
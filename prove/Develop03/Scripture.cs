public class Scripture
{
    private Reference _reference;
    private List<Word> _words;



    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        foreach (Word word in _words)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {

    }

    public bool IsCompletelyHidden()
    {

    }
}
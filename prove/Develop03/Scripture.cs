using System.ComponentModel;

public class Scripture
{
    //state
    private Reference _reference; 
    private List<Word> _words; //internally stores list of words


    //behavior
    public Scripture(Reference Reference, string text) //keeps track of both the reference and scripture's text
    {
        _reference = new Reference();
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide) //hides random words
    {
        Random randomWord = new Random();

        string[] words = text.Split(' ');
        StringBuilder randomWord = new StringBuilder();

        foreach (string word in _words)
        {
            if (new Random().NextInt() < numberToHide)
            {
                randomWord.Append(new string('_', word.Length) + " ");
            }
            else
            {
                randomWord.Append(word + " ");
            }
        }

    }
    public string GetDisplayText() //gets display text
    {
        Console.WriteLine($"{_reference}");

    }
    public bool IsCompletelyHidden() //checks to see if all the words of the scripture are hidden
    {
        return true;
    }
}
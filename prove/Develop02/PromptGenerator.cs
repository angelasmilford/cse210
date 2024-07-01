public class PromptGenerator
{
    public List<string> _prompts = new List<string>() 
    {
        "What made me smile today?",
        "What was challenging today?",
        "How did I feel today?",
        "What did I do well today?",
        "What could I have done better today?"
    };


    public string GetRandomPrompt()
    {   
        Random random = new Random();

        int promptCount = _prompts.Count;

        int promptIndex = random.Next(promptCount);

        string _promptText = _prompts[promptIndex];

        return _promptText;
    }
}
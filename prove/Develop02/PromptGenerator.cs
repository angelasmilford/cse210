public class PromptGenerator
//supplies random prompts whenever needed
{
    //state
    public List<string> _prompts = new List<string>
    {
        "How did I feel today?",
        "What am I grateful for today?",
        "What made me smile today?",
        "What did I learn today?",
        "What was challenging today?",
    };

    //behavior
    public string GetRandomPrompt()
    {
        foreach (PromptGenerator _promptText in _prompts)
        {
            Console.Write($"{_promptText}");
        }

        return "{_promptText[index]}";
    }
}
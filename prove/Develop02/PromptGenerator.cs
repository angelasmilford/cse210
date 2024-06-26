using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
//supplies random prompts whenever needed
{
    public List<string> _prompts = new List<string>()
    {
        "How did I feel today?",
        "What am I grateful for today?",
        "What made me smile today?",
        "What did I learn today?",
        "What was challenging today?",
    };


    public string GetRandomPrompt() //NEEDS WORK
    {;

        Random random = new Random();
        int _promptText = random.Next(_prompts.Count);
        return _prompts[_promptText];
    }

}
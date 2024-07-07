using System;

namespace mindfullness
{
    public class ReflectingActivity : Activity
    {
        
        /*
            starting message and prompt for duration
            describe breathing activity
            select random prompt
            reflect on questions
            pause
            continue to show random questions
            finishing message
        */
        
        private List<string> _prompts = new List<string> 
        {
            "--- Think of a time when you stood for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };
        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        }; 


        public ReflectingActivity() //NEEDS WORK
        {
            SetName("Reflecting Activity");
            SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }
        public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base (name, description, duration)
        {
            _prompts = prompts;
            _questions = questions;
            name = "Reflecting Activity";
        }

        public void Run() 
        {
            string prompt = GetRandomPrompt();
            string question = GetRandomQuestion();

            Console.WriteLine("");
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("");
            Console.WriteLine($"{prompt}");
            Console.WriteLine("");
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            //pause
            
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int promptIndex = random.Next(0, _prompts.Count);
            string prompt = _prompts[promptIndex];

            return prompt;
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int questionIndex = random.Next(0, _questions.Count);
            string question = _questions[questionIndex];

            return question;
        }

        public void DisplayPrompt() //NEEDS WORK
        {
            Console.WriteLine(prompt);
        }

        public void DisplayQuestions() //NEEDS WORK
        {
            Console.WriteLine(question);
        }
    }
}
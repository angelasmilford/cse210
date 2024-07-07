using System;

namespace mindfullness
{
    public class ListingActivity : Activity
    {
        /*
            begin with starting message
            describe the activity
            select random prompt
            give countdown
            prompt them to keep listing items
            display the number of listed items
            standard finishing message
        */
        
        private int _count;
        private List<string> _prompts = new List<string>
        {
            "--- Who are the people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are the people that you've helped this week? ---",
            "--- When have you felt the Holy Ghost in this month? ---",
            "--- Who are some of your personal heroes? ---"
        };


        public ListingActivity()
        {
            SetName("Listing Activity");
            SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }

        public void Run()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine("");
            Console.WriteLine("List as many responses you want to the following prompt: ");
            string list = Console.ReadLine();
            Console.WriteLine("---{prompt}---");
            Console.WriteLine("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine("");
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int promptIndex = random.Next(0, _prompts.Count);
            string prompt = _prompts[promptIndex];

            return prompt;
        }

        public List<string> GetListFromUser() //NEEDS WORK
        {
            return list;
        }
    }
}
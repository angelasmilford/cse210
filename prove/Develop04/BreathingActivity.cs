using System;

namespace mindfullness
{
    public class BreathingActivity : Activity
    {
        
        /*
            starting message
            describe breathing activity
            show a series of alternating messages
            pause and show a countdown
            continue once countdown finishes
            finishing message
        */
        
        public BreathingActivity()
        {
            SetName("Breathing Activity");
            SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }

        public void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);

        }
    }
}
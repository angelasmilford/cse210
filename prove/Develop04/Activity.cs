public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public void DisplayStartingMessage() //NEEDS WORK
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage() //NEEDS WORK
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine($"This {_name} activity took {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write(" ");

        var spinner = new[] {'↑', '↗', '→', '↘', '↓', '↙', '←', '↖'};
        if (blink)
        {
            spinner = new[] {' ', '_', ' ', '_'};
        }

        for (var i = 0; i < seconds; i++)
        {
            foreach (var c in spinner)
            {
                Console.Write($"\b{c}");
                Thread.Sleep(1000 / spinner.Length);
            }
        }

        Console.Write("\b \b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
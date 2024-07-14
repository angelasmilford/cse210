using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        _goals.Add(goal);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player has {_score} or the {_goals} he/she set.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. ");
            _goals[i].ListGoalDetails();
            Console.WriteLine("");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("Your goals are:");

            int index = 1;

            foreach(Goal goal in _goals)
            {
                goal.ListGoal(index);
                index += 1;
            }
        }
        else
        {
            Console.WriteLine("You don't have any goals.");
        }
    }

    public void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = (Console.ReadLine());
        _points = Convert.ToInt32(stringGoalPoints);
    }

    public virtual void RecordEvent()
    {
        ListGoalDetails();

        Console.WriteLine("Which goal did you accomplished? ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine($"You have {_score} points!");
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(GetTotalPoints());
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            // skip the first line of text file to read to goals
            readText = readText.Skip(1).ToArray();
            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool isComplete = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Goal:")
                {
                    Goal goal = new Goal(name, description, points);
                    CreateGoal(goal);
                }
                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    CreateGoal(simpleGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    CreateGoal(eternalGoal);
                }
                if (entries[0] == "Checklist Goal:")
                {
                    int amountCompleted = int.Parse(entries[5]);
                    int target = int.Parse(entries[6]);
                    int bonus = int.Parse(entries[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    CreateGoal(checklistGoal);
                }
            }
        }
    }
}
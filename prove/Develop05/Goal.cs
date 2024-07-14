using System;
using System.ComponentModel;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;


    public abstract Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract bool IsComplete()
    {
        return false;
    }

    public abstract string GetDetailsString()
    {
        Console.WriteLine($"{_shortName}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"You have {_points}");
    }

    public abstract string GetStringRepresentation()
    {
        Console.WriteLine($"Your goals is {_shortName} {_description}, and you have {_points} points.");
    }
}




public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public override void RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_isComplete == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"The simple goals you completed are {_shortName}. Now you have {_points} points.");
        }
        else
        {
            Console.WriteLine("You haven't completed a goal yet.");
        }
    }
}




public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    
    public void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"The eternal goals you completed are {_shortName}. Now you have {_points} points.");
        }
        else
        {
            Console.WriteLine("You haven't completed a goal yet.");
        }
    }
}




public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;



    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }


    public void RecordEvent()
    {
        _amountCompleted ++;
    }

    public override bool IsComplete()
    {   
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        Console.WriteLine($"{_shortName}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"You have {_points} points.");
        Console.WriteLine($"You have {_targets} targets.");
        Console.WriteLine($"You received {_bonus} bonus(es).");
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"The goals you completed are {_shortName}. Now you have {_points} points.");
        }
        else
        {
            Console.WriteLine("You haven't completed a goal yet.");
        }
    }
}
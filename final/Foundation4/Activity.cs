using System;

public class Activity
{
    protected DateTime _date;
    private int _duration; //in minutes


    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    
    public virtual string GetExerciseName()
    {
        return "Generic Exercise";
    }

    public virtual double GetDistance() //in miles
    {
        return 2002;
    }

    public virtual double GetSpeed() //mph
    {
        return 2006;
    }

    public virtual double GetPace() //minutes in miles
    {
        return 2011;
    }

    public virtual string GetSummary() //produce a string with all the summary information; make use of the other methods to produce its result
    {
        return "Summary";
    }

    public int GetTime()
    {
        return _duration;
    }
}

public class Running : Activity
{
    private double _distance;


    public Running(DateTime date, int duration, double distance) : base (date, duration)
    {
        _distance = distance;
    }
    
    public override string GetExerciseName()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed() 
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{_date} {GetExerciseName()} ({_duration} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

public class Cycling : Activity
{
    private double _speed;


    public Cycling (DateTime date, int duration, double speed) : base (date, duration)
    {
        _speed = speed;
    }

    public override string GetExerciseName()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * 12;    
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace() //min per mile
    {
        return GetTime() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} {GetExerciseName()} ({_duration} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

public class Swimming : Activity
{
    private int _lapCount;


    public Swimming(DateTime date, int duration, int lapCount) : base (date, duration)
    {
        _lapCount = lapCount;        
    }
    
    public override string GetExerciseName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return (_lapCount * 50) / 1000;        
    }

    public override double GetSpeed() 
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} {GetExerciseName()} ({_duration} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
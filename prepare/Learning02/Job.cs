public class Job
{
    //state
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //behavior
    public void Display() //displays job details
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
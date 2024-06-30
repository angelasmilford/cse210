public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person() //no-argument constructor
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }
    
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }
    public Person (string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }

    public string GetInformationSignature()
    {
        return "Thanks, " + _firstName;
    }
    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }
    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }

    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName (string firstName)
    {
        _firstName = firstName;
    }
}
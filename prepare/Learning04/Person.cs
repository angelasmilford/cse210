public class Person //parent class
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }
    
    public string GetName()
    {
        return "Angela";
    }
}



// a class that inherits from Person
//triangle
public class Student : Person //child class
{
    private string _number;

    public Student(string name, string number) : base (name) //calling the parent constructor using "base"
    {
        _number = number;
    }
    
    public string GetNumber()
    {
        return _number;
        //return "0123456789";
    }
}
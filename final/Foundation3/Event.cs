using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected Address _address;


    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }
    
    public virtual string GetEventTypeName()
    {
        return $"Generic Event";
    }

    public virtual string GetDetails()
    {
        return $"Details";
    }

    public string GetStandardDetails() //lists title, description, datetime, and address
    {
        return $"Title: {_title} | Description: {_description} | Date: {_date} | {_address}";
    }

    public string GetFullDetails() //lists standard details plus event type and specific infromation
    {
        return $"{GetStandardDetails()} | {GetEventTypeName()} | {GetDetails()}";
    }

    public string GetShortDescription() //list type of event, title, and date
    {
        return $"{GetEventTypeName()}: {_title}, {_date}";
    }
}




public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;


    public Lecture (string title, string description, DateTime date, Address address, string speaker, int maxCapacity) : base (title, description, date, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public override string GetEventTypeName()
    {
        return "Lecture";
    }

    public override string GetDetails() //NEEDS WORK
    {
        return $"Speaker: {_speaker}, Capacity Limit: {_maxCapacity}";
    }
}




public class Reception : Event
{
    private string _rsvpEmail;


    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail) : base (title, description, date, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    
    public override string GetEventTypeName()
    {
        return "Reception";
    }

    public override string GetDetails()
    {
        return $"RSVP Email: {_rsvpEmail}";
    }
}




public class Outdoor : Event
{
    private string _weatherForecast;


    public Outdoor(string title, string description, DateTime date, Address address, string weatherForecast) : base (title, description, date, address)
    {
        _weatherForecast = weatherForecast;
    }
    
    public override string GetEventTypeName()
    {
        return "Outdoor Event";
    }

    public override string GetDetails()
    {
        return $"Weather: {_weatherForecast}";
    }
}
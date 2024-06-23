using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._givenName = "Angela";
        person._familyName = "Milford";
        person.ShowEasterName();
        person.ShowWesternName();
    }
}
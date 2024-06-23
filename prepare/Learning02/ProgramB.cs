using System;

class Program
{
    static void Main(string[] args)
    {
        Blind kitchen = new Blind();

        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "White";

        double materialAmount = kitchen.GetArea();
    

        House milfordHome = new House();
        
        milfordHome._kitchen = new Blind();
        milfordHome._livingRoom = new Blind();
    

        House milfordHome = new House();
        milfordHome._owner = "Milford Family";


        milfordHome._kitchen._width = 60;
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        var _videos = new List<Video>
        {
            new Video("How to fix Xbox 360's Ring of Death", "Jake", 300),
            new Video("Why Microsoft discontinues the Xbox Kinect", "Shane", 430),
            new Video("Xbox Series X Unboxing", "Troy", 500),
            new Video("Xbox Fridge Review", "Riley", 624)
        };



        _videos[0].AddComment("Wallace", "I still can't do it.");
        _videos[0].AddComment("Xander", "Thanks! You're a lifesaver.");
        _videos[0].AddComment("Owen", "YES. MINE'S WORKING");
            
        _videos[1].AddComment("Flynn", "Man, right when I was just starting to like playing the kinect games");
        _videos[1].AddComment("Sarah", "The Xbox Kinect will forever be missed.");
        _videos[1].AddComment("Ben", "Kinect was bound to be discontinued");

        _videos[2].AddComment("Caldur", "Stoked to get mine!");
        _videos[2].AddComment("Lily", "Wow, really putting box in Xbox, haha");
        _videos[2].AddComment("Bob", "PS5 is wayyyy better!");

        _videos[3].AddComment("Amy", "That's pretty cool");
        _videos[3].AddComment("Walter", "Now I want one");
        _videos[3].AddComment("Lynn", "Seems like a decent fridge");



        foreach (Video video in _videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            //Console.WriteLine($"{video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetName()}");
            //Console.WriteLine($"{video.GetName()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            //Console.WriteLine($"{video.GetLength()}");
            Console.WriteLine($"{video.GetCommentCount()} Comments");
            Console.WriteLine();
            foreach (var comment in video.GetComments())
            {
                //Console.WriteLine($"Name: {comment._author}");
                //Console.WriteLine($"Text: {comment._text}");
                //Console.WriteLine($"{comment._author} \n {comment._text}");
                Console.WriteLine($"{comment._author}");
                Console.WriteLine($"{comment._text}");
                Console.WriteLine();
            }
            Console.WriteLine();
            //Console.WriteLine();
        }
    }
}
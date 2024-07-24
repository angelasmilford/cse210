using System;

class Program
{
    static void Main(string[] args)
    {
        var _videos = new List<Video>
        {
            new Video("How to fix Xbox 360's Ring of Death", "Richard Grayson", 350),
            new Video("Why Microsoft discontinues the Xbox Kinect", "Wallace West", 430),
            new Video("Xbox Series X Unboxing and Review", "Victor Stone", 300),
            new Video("Xbox Fridge Review", "Garfield Logan", 345)
        };


        _videos[0].AddComment("King Shark", "I still can't do it.");
        _videos[0].AddComment("Conner Kent", "Thanks! You're a lifesaver.");
        _videos[0].AddComment("Garfield Logan", "YES. MINE'S WORKING");
            
        _videos[1].AddComment("Jaime Reyes", "Man, right when I was just starting to like playing the kinect games");
        _videos[1].AddComment("Cassandra Sandsmark", "The Xbox Kinect will forever be missed.");
        _videos[1].AddComment("Damian Wayne", "Kinect was bound to be discontinued");

        _videos[2].AddComment("Jason Todd", "Stoked to get mine!");
        _videos[2].AddComment("Oliver Queen", "Wow, really putting box in Xbox, haha");
        _videos[2].AddComment("Joker", "PS5 is wayyyy better!");

        _videos[3].AddComment("Rachel Roth", "That's pretty cool");
        _videos[3].AddComment("Bart Allen", "Now I want one");
        _videos[3].AddComment("Timothy Drake", "Seems like a decent fridge");


        foreach (Video video in _videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            //Console.WriteLine($"{video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetName()}");
            //Console.WriteLine($"{video.GetName()}");
            Console.WriteLine($"Length: {video.GetLength()}");
             Console.WriteLine($"{video.GetCommentCount()} Comments");
            Console.WriteLine();
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment._author}");
                Console.WriteLine($"{comment._text}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
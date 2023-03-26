using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Console.WriteLine("Welcome to the Youtube program!");
        
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Surviving Alone In The Wilderness";
        video1._author = "Peter Mckinnon";
        video1._length = "930";

        Comment comment1 = new Comment();
        comment1._name = "Tom Johnson";
        comment1._comment = "Some filmmakers would've been playing music but you brought out more of my senses by just leaving the natural sounds audible. I could feel the wind, smell the fire and taste the whisky, Bravo!";

        Comment comment2 = new Comment();
        comment2._name = "Trent Nelson";
        comment2._comment = "I love this video";

        Comment comment3 = new Comment();
        comment3._name = "Claudio Desideri Films";
        comment3._comment = "This 'simple' footage just kept me immersed in the story for 15 mins straight and gave me such a sense of relaxation. This is ASMR for the eyes, thanks!";

        Comment comment4 = new Comment();
        comment4._name = "Joe Smith";
        comment4._comment = "So relaxing...";

        video1.comments.Add(comment1);
        video1.comments.Add(comment2);
        video1.comments.Add(comment3);
        video1.comments.Add(comment4);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Why Dogs are the Best Pet";
        video2._author = "Dogman";
        video2._length = "500";

        Comment comment5 = new Comment();
        comment5._name = "Bill Gates";
        comment5._comment = "I love my dog even more";

        Comment comment6 = new Comment();
        comment6._name = "Taylor Nelson";
        comment6._comment = "I wish I had a dog!";

        Comment comment7 = new Comment();
        comment7._name = "JoeShmoe";
        comment7._comment = "Truly a mans best friend";

        video2.comments.Add(comment5);
        video2.comments.Add(comment6);
        video2.comments.Add(comment7);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Why Cats make the Best Pets";
        video3._author = "Cat Lady 32";
        video3._length = "400";

        Comment comment8 = new Comment();
        comment8._name = "Kathy";
        comment8._comment = "I love my cat so much!";

        Comment comment9 = new Comment();
        comment9._name = "Francis";
        comment9._comment = "Cats really are the best";

        Comment comment10 = new Comment();
        comment10._name = "Bill Gates";
        comment10._comment = "Never been much of a cat person, I love my dog though";


        video3.comments.Add(comment8);
        video3.comments.Add(comment9);
        video3.comments.Add(comment10);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            
        }

    }
}
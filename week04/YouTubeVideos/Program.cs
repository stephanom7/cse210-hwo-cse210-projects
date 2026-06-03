using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Learning C# Basics",
            "Code Academy",
            600);

        video1.AddComment(
            new Comment("Alice",
            "Very helpful tutorial!"));

        video1.AddComment(
            new Comment("Bob",
            "I learned a lot."));

        video1.AddComment(
            new Comment("Charlie",
            "Great explanation!"));

        Video video2 = new Video(
            "Top 10 Travel Destinations",
            "Travel World",
            900);

        video2.AddComment(
            new Comment("Sophia",
            "Beautiful places!"));

        video2.AddComment(
            new Comment("James",
            "Adding these to my bucket list."));

        video2.AddComment(
            new Comment("Emma",
            "Amazing video."));

        Video video3 = new Video(
            "Healthy Breakfast Ideas",
            "Food Channel",
            480);

        video3.AddComment(
            new Comment("Lucas",
            "Looks delicious."));

        video3.AddComment(
            new Comment("Olivia",
            "Can't wait to try this."));

        video3.AddComment(
            new Comment("Mia",
            "Thanks for sharing."));

        Video video4 = new Video(
            "Gaming Highlights 2026",
            "Pro Gamer",
            720);

        video4.AddComment(
            new Comment("Noah",
            "Awesome gameplay!"));

        video4.AddComment(
            new Comment("Ethan",
            "That last move was insane."));

        video4.AddComment(
            new Comment("Ava",
            "Loved this video."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
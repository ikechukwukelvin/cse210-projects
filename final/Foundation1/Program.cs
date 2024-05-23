using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Introduction to C#", "Alice", 300);
        Video video2 = new Video("Understanding OOP", "Bob", 600);
        Video video3 = new Video("Advanced C# Techniques", "Charlie", 900);

        // Add comments to video1
        video1.AddComment(new Comment("John", "Great video!"));
        video1.AddComment(new Comment("Jane", "Very informative."));
        video1.AddComment(new Comment("Smith", "Helped me a lot, thanks!"));

        // Add comments to video2
        video2.AddComment(new Comment("Alice", "Clear and concise."));
        video2.AddComment(new Comment("Bob", "Loved the examples."));
        video2.AddComment(new Comment("Charlie", "Thanks for sharing!"));

        // Add comments to video3
        video3.AddComment(new Comment("David", "Awesome tutorial!"));
        video3.AddComment(new Comment("Eve", "Well explained."));
        video3.AddComment(new Comment("Frank", "Could use more examples."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display their details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line for better readability
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create 3-4 Video objects
        Video video1 = new Video("C# Fundamentals: Part 1", "Microsoft Learn", 720);
        Video video2 = new Video("Introduction to Object-Oriented Programming", "Code Academy", 900);
        Video video3 = new Video("Building a Simple Web API with ASP.NET Core", "Dev Unleashed", 1800);
        Video video4 = new Video("Data Structures Explained: Arrays and Lists", "Algo Insights", 600);

        // Add 3-4 comments to each video
        video1.AddComment(new Comment("Alice Smith", "Great starting point for beginners!"));
        video1.AddComment(new Comment("Bob Johnson", "Very clear explanations. Thanks!"));
        video1.AddComment(new Comment("Charlie Brown", "I wish there was more on error handling."));
        video1.AddComment(new Comment("Diana Prince", "Looking forward to Part 2!"));

        video2.AddComment(new Comment("Eve Adams", "Helped me grasp OOP concepts better."));
        video2.AddComment(new Comment("Frank White", "Excellent examples of encapsulation."));
        video2.AddComment(new Comment("Grace Green", "Could you do a video on design patterns?"));

        video3.AddComment(new Comment("Henry Black", "Very practical tutorial, easy to follow."));
        video3.AddComment(new Comment("Ivy Lee", "I learned a lot about routing and controllers."));
        video3.AddComment(new Comment("Jack King", "The best ASP.NET Core tutorial so far!"));
        video3.AddComment(new Comment("Karen Hall", "What about database integration?"));

        video4.AddComment(new Comment("Liam Scott", "Simple and effective explanation of arrays."));
        video4.AddComment(new Comment("Mia Taylor", "Good review for my upcoming exam."));
        video4.AddComment(new Comment("Noah Clark", "Could you cover trees and graphs next?"));

        // Put each of these videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            // List out all the comments for the current video
            if (video.GetNumberOfComments() > 0)
            {
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetCommentText()}");
                }
            }
            else
            {
                Console.WriteLine("  No comments for this video.");
            }
            Console.WriteLine(); // Add a blank line for better readability between videos
        }
    }
}

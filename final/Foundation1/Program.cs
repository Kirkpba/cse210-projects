class Program
{
    static void Main(string[] args)
    {
        // Create sample videos
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        Video video2 = new Video("Advanced Programming Tips", "Jane Smith", 450);
        Video video3 = new Video("Debugging Made Easy", "Chris Brown", 600);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "This video is amazing!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "I learned a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "I am going to punch a hole through your face."));

        // Add comments to video 2
        video2.AddComment(new Comment("Diana", "Love the tips shared here."));
        video2.AddComment(new Comment("Eve", "Clear and concise explanation."));
        video2.AddComment(new Comment("Dawn", "lol"));

        // Add comments to video 3
        video3.AddComment(new Comment("Frank", "Debugging is now less scary."));
        video3.AddComment(new Comment("Grace", "Helpful for beginners and experts alike."));
        video3.AddComment(new Comment("Hank", "Clear step-by-step process!"));
        
        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };
        // Display each video and its comments

        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine(video.ToString());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment}");
            }
            Console.WriteLine();
        }
    }
}
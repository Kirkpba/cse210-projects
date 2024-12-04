// Video class to encapsulate video details and associated comments
public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // Get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    // Get all comments as a formatted string
    public List<Comment> GetComments()
    {
        return _comments;
    }
    // Convert video information to a string
    public override string ToString()
    {
        return $"{_title} by {_author}, Length: {_lengthInSeconds} seconds, Comments: {GetCommentCount()}";
    }
}
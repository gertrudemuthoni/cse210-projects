public class Comment
{
    public string _commentor;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine("Commentor: " + _commentor);
        Console.WriteLine("Comment: " + _commentText);
    }
}
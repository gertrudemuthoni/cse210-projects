public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor for the Writing class
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing details
    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }
}

public class Writing : Assignment
{
    private string _title;

    // Constructor for the Writing class
    public Writing(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get the writing details
    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }
}

public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor for the Assignment class
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the student summary
    public string GetSummary()
    {
        return $"Student Name: {_studentName}, Topic: {_topic}";
    }
}




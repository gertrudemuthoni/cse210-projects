public class Math : Assignment
{
   private string _textbookSection; 
    private string _problems;

    // Constructor for the Math class
    public Math(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get the homework details
    public string GetHomeworkList()
    {
        return $"Textbook Section: {_textbookSection}, Problems: {_problems}";
    }
}
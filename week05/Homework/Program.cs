using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate 3 Math Objects
        MathAssignment math1 = new MathAssignment("John Doe", "Algebra", "Chapter 1", "Problems 1-10");
        MathAssignment math2 = new MathAssignment("Jane Smith", "Geometry", "Chapter 2", "Problems 11-20");
        MathAssignment math3 = new MathAssignment("Alice Johnson", "Calculus", "Chapter 3", "Problems 21-30");

        // Create a list of Math objects
        List<MathAssignment> mathAssignments = new List<MathAssignment>();
        mathAssignments.Add(math1);
        mathAssignments.Add(math2);
        mathAssignments.Add(math3);

        // Display the homework details for each Math object
           foreach (MathAssignment math in mathAssignments)
           {
            Console.WriteLine(math.GetSummary());
            Console.WriteLine(math.GetHomeworkList());
            Console.WriteLine();
           }

        //    Instantiate 3 WritingAssignment objects
        WritingAssignment writing1 = new WritingAssignment("John Doe", "Essay", "The Great Gatsby");
        WritingAssignment writing2 = new WritingAssignment("Jane Smith", "Research Paper", "Climate Change Effects");
        WritingAssignment writing3 = new WritingAssignment("Alice Johnson", "Short Story", "The Last Leaf");

        // Create a list of WritingAssignment objects
        List<WritingAssignment> writingAssignments = new List<WritingAssignment>();
        writingAssignments.Add(writing1);
        writingAssignments.Add(writing2);
        writingAssignments.Add(writing3);

        // Display the writing details for each WritingAssignment object
        foreach (WritingAssignment writing in writingAssignments)
        {
            Console.WriteLine(writing.GetSummary());
            Console.WriteLine(writing.GetWritingInformation());
            Console.WriteLine();
        }
        


    }
}
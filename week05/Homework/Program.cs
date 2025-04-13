using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate 3 Math Objects
        Math math1 = new Math("John Doe", "Algebra", "Chapter 1", "Problems 1-10");
        Math math2 = new Math("Jane Smith", "Geometry", "Chapter 2", "Problems 11-20");
        Math math3 = new Math("Alice Johnson", "Calculus", "Chapter 3", "Problems 21-30");

        // Create a list of Math objects
        List<Math> mathAssignments = new List<Math>();
        mathAssignments.Add(math1);
        mathAssignments.Add(math2);
        mathAssignments.Add(math3);

        // Display the homework details for each Math object
           foreach (Math math in mathAssignments)
           {
            Console.WriteLine(math.GetSummary());
            Console.WriteLine(math.GetHomeworkList());
            Console.WriteLine();
           }

        //    Instantiate 3 WritingAssignment objects
        


    }
}
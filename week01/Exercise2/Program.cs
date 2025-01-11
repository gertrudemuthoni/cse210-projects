using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.WriteLine("Enter your grade percentage?: ");
        /*Also written as
        string grade = console.ReadLine();
        int percentage = int.Parse(grade);
        */
        int percent = int.Parse(Console.ReadLine());
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}");

        if (percent >= 70)
        {
            Console. WriteLine("You passed this class!");
        }

        else
        {
            Console.WriteLine("Try again next semester!");
        }
    }    
}        
    
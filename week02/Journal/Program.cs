using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could change about today, what would it be?", 
        };

        bool running = true;   

        while (running)
        {
            Console.WriteLine("\n Journal Menu");   
            Console.WriteLine("1. Write");           
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");   
            Console.WriteLine("5. Quit");

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine(" Select a prompt: "); 
                    Console.WriteLine();
                    for (int i = 0; i < prompts.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {prompts[i]}");
                    }  
                    int promptIndex = int.Parse(Console.ReadLine());
                    Console.WriteLine(prompts[promptIndex - 1]);    
                    Console.WriteLine("Enter your response: "); 
                    string response = Console.ReadLine();   
                    journal.AddEntry(prompts[promptIndex - 1], response);   
                    break;

                case "2":
                    journal.DisplayEntries();   
                    break;

                case "3":
                    Console.WriteLine("Enter the name of the file you would like to load: ");
                    string loadFileName = Console.ReadLine(); 
                    journal.LoadFromFile(loadFileName);   
                    break;

                case "4":
                    Console.WriteLine("Enter the name of the file you would like to save: ");
                    string saveFileName = Console.ReadLine();   
                    journal.SaveToFile(saveFileName);   
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;                    
            }
        }   
    }
}    


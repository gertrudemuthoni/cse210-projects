using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:");
        JournalEntry journalEntry = new JournalEntry("", "");//create a new instance of the JournalEntry class 
        Journal journal = new Journal(); // create a new instance of the Journal class
        bool running = true;    

        while (running)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");   
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    WriteNewEntry(journal);   
                    break;
                case "2":
                    journal.DisplayEntries();   
                    break;
                case "3":
                    LoadJournal(journal);
                    break;
                case "4":
                    SaveJournal(journal);
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
    static void WriteNewEntry(Journal journal)
    {
        //Display prompts   
        string [] prompts = journal.GetAllPrompts(); 
        Console.WriteLine("Select a prompt from the following list:");    
        for (int i = 0; i < prompts.Length; i++)    
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }   
        
        // Ger user input   
        int promptChoice = -1;
        while(promptChoice < 1 || promptChoice > prompts.Length)
        {
            Console.WriteLine("Enter the number of the prompt you would like to use:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out promptChoice)|| promptChoice < 1 || promptChoice > prompts.Length)    
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        string selectedPrompt = prompts[promptChoice - 1];
        Console.WriteLine($"Selected prompt: {selectedPrompt}");    
        Console.WriteLine("Enter your response:");  
        string response = Console.ReadLine();  

        journal.AddEntry(selectedPrompt, response); 
        Console.WriteLine("Entry added successfully!");

    }
    static void LoadJournal(Journal journal)
    {
        Console.WriteLine("Enter the name of the file you would like to load:");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
         
    } 

    static void SaveJournal(Journal journal)
    {
        Console.WriteLine("Enter the name of the file you would like to save to:");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName); 
    }
}


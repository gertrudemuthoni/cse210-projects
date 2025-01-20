
using System;   
using System.IO;   // Necessary for streamwriter   

public class Journal
{
    public List<JournalEntry> Entries {get; set;}

    public Journal()
    {
        Entries = new List<JournalEntry>();  
    }   
    public void AddEntry(string userPrompt, string userResponse)
    {
        JournalEntry newEntry = new JournalEntry(userPrompt, userResponse);
        Entries.Add(newEntry);      
    }
    public void DisplayEntries()
    {
        foreach (JournalEntry entry in Entries)
        {
            entry.DisplayEntries();
            Console.WriteLine();
        }
    }
    
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in Entries)
            {
                writer.WriteLine($"{entry.UserPrompt}, {entry.UserResponse}, {entry.EnterDate}");   
    

            }
        }

    Console.WriteLine($"Entry added successfully to {fileName}!");
} 

public void LoadFromFile(string fileName)
{
    string[] lines = File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        string[] parts = line.Split(',');
        if (parts.Length >= 2)
        {
            AddEntry(parts[0], parts[1]);
        }   
    }
    Console.WriteLine($"Entries loaded successfully from {fileName}!");
}

public string GetRandomPrompts()
{
    string[] prompts = GetAllPrompts(); 
    var random = new Random();
    return prompts[random.Next(prompts.Length)];
}
public string[] GetAllPrompts()
{
    return new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
}
}  




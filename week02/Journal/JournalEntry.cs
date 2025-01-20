using System;
using System.Dynamic;

public class JournalEntry  
{
    public string UserPrompt{get; set;}
    public string UserResponse{get; set;} 
    public DateTime EnterDate{get; set;}

    public JournalEntry(string userPrompt, string userResponse)
    {
        UserPrompt = userPrompt;
        UserResponse = userResponse;
        EnterDate = DateTime.Now;   
    }  

    public void DisplayEntries()
    {
        Console.WriteLine($"Prompt: {UserPrompt}");
        Console.WriteLine($"Response: {UserResponse}");
        Console.WriteLine($"Date: {EnterDate}");    
    }

    public string AddEntry()
    {
        return $"{UserPrompt},{UserResponse},{EnterDate}";
    }        
}
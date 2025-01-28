using System;
using System.Dynamic;

public class JournalEntry  
{
    public string Prompt{get; set;}
    public string Response{get; set;} 
    public string Date{get; set;}

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;   
    }
    public void Display()
    {
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Date: {Date}");    
    
    }       
}
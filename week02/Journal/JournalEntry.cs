using System;
using System.Dynamic;

public class JournalEntry  
{
    public string _prompt;
    public string _response; 
    public string _date;

    public JournalEntry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;

    }
    public void Display()
    {
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Date: {_date}");    

    }       
}
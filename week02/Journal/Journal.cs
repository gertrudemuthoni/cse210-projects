
using System;   
using System.IO;   // Necessary for streamwriter   

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();    
    public void AddEntry(string prompt, string response)
    {
        string currentDate = DateTime.Now.ToString("MM/dd/yyyy");   
        entries.Add(new JournalEntry(prompt, response, currentDate));
    }
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }   
        else
        {
            foreach (JournalEntry entry in entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }
    
    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (JournalEntry entry in entries)
                {
                    writer.WriteLine($"{entry.Prompt}, {entry.Response}, {entry.Date}");
                }
            }
            Console.WriteLine($"Entry added successfully to {fileName}!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving to {fileName}: {e.Message}");
        }
    } 

    public void LoadFromFile(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    entries.Add(new JournalEntry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine($"Entries loaded successfully from {fileName}!");     
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading from {fileName}: {e.Message}");
        }       
    }
}  




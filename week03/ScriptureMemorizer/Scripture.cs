using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;  
    private Random _random;

    public Scripture(string book, int chapter, int startVerse, string text, int? endVerse = null)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();   
        _random = new Random();
    } 

    public bool HideWords(int count)
    {
        var availableWords = _words.Where(word => !word.isHidden).ToList(); 
        if (availableWords.Count == 0) return false;
    
            for( int i=0; i < count && availableWords.Count > 0; i++)
            {
                var word = availableWords[_random.Next(availableWords.Count)];
                word.Hide();
                availableWords.Remove(word);
    
            }
            return true;
        }
        
            public void Display()
            {
                Console.Clear();
                Console.WriteLine(_reference);
                Console.WriteLine(string.Join(" ", _words));
                Console.WriteLine();
            }


        }
         

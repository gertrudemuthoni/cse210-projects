using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;
            }
            else
            {
                scripture.HideWords(2);

            }
            
        }
    }
}
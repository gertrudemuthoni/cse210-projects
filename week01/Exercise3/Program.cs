using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        int guess = -1;

        while (guess != randomNumber)
        {            
            Console.WriteLine("What is your ?: ");
            guess = int.Parse(Console.ReadLine());
            
            if (randomNumber < guess)
            {
                Console.WriteLine("higher");
            }
            else if (randomNumber > guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
using System;

class GuessGame
{
    static void Main()
    {
        string[] secretNames =  {"UCT", "UJ", "UKZN", "DUT", "Wits", "UP", "SU", "UWC", "UNISA", "NWU", "UL", "UFH", "UFS", "CUT", "TUT", "VUT", "NMMU", "Rhodes", "SMU", "CPUT", "MUT", "WSU"};
        string guess;
        int guessCount = 0;
        int correctGuess = 0;
        int guessLimit = 3;

        Console.WriteLine("Welcome To The University Guessing Game");
        Console.WriteLine("");
        Console.WriteLine("Guess the name of a South African University you Love");
        Console.WriteLine("");
        Console.WriteLine("Note that the names are in a abbreviated form");
        Console.WriteLine("");
        Console.WriteLine("You have 3 chances to guess the correct name");
        Console.WriteLine("");
        Console.WriteLine("Good Luck");

        while (guessCount < guessLimit)
        {
            Console.WriteLine("Enter your guess: ");
            guess = Console.ReadLine();
            guessCount++;

            if (secretNames.Contains(guess))
            {
                correctGuess++;
            }
            else
            {
                Console.WriteLine("Incorrect guess. Try again.");
            }
            if (correctGuess >= 3)
            {
                Console.WriteLine("Congratulations! You have guessed the correct name of a university in South Africa.");
                break;
            }

        }

        if (correctGuess < 3)
        {
            Console.WriteLine("You have exhausted your chances. The correct names of universities in South Africa are: ");
            
            for (int i = 0; i < secretNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {secretNames[i]}");
            }

        }
    }
}




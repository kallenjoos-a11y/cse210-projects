using System;

class Program
{
    static void Main(string[] args)
    {
        int guessNum;
        string result;

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if(magicNum > guessNum)
            {
                result = "Higher";
            } else if(magicNum < guessNum)
            {
                result = "Lower";
            } else
            {
                result = "You guessed it!";
            }

            Console.WriteLine(result);

        }
        while(magicNum != guessNum);

        {
            result = "Higher";
        }
    }
}
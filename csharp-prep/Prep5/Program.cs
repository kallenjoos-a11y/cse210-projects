using System;
using System.Reflection.Metadata;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

     static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What is your birth year? ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int userNum)
    {
        int squared = userNum * UserNum;
        return squared;
    }

    static void DisplayResult(string userName, int squaredNum, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        int userAge = 2026 - birthYear;
        Console.WriteLine($"{userName}, you will turn {userAge} this year.");
    }

    static void Main(string[] args)
    {
        int birthYear;

        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        PromptUserBirthYear(out birthYear);

        int squaredNum = SquareNumber(userNum);

        DisplayResult(userName, squaredNum, birthYear);
    }
}
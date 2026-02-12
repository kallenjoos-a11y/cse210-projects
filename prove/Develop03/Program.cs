using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Reference r1;

        string verse = GetScriptureFromUser();

        Console.Write("Enter the scripture book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the scripture chapter: ");
        string chap = Console.ReadLine();

        Console.Write("Does the scripture have multiple verses? ");
        string verseAmount = Console.ReadLine();

        Console.Write("Enter the first scripture verse: ");
        string fVerse = Console.ReadLine();

        if(verseAmount.ToLower() == "yes" || verseAmount.ToLower() == "y")
        {
            Console.Write("Enter the final scripture verse: ");
            string lVerse = Console.ReadLine();

            r1 = new Reference(book, chap, fVerse, lVerse);
        } else
        {
            r1 = new Reference(book, chap, fVerse);
        }

        
        
        Scripture s1 = new Scripture(scrip);
        
        Console.WriteLine($"{r1.CombineReference()}");

        public string GetScriptureFromUser()
        {
        Console.Write("Enter a scripture: ");
        return Console.ReadLine();
        }
    }
}

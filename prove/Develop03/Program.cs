using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static Word w1 = new Word();
    static Scripture s1;
    static void Main(string[] args)
    {
        string input = "";
        string scrip = GetScriptureFromUser();
        Reference r1 = GetRefFromUser();
        
        s1 = new Scripture(scrip);
        string scripture = s1.GetScripture();
        string combinedRef = r1.CombineReference();

        Console.Clear();
        Console.WriteLine(combinedRef);
        Console.WriteLine(scripture);

        w1.SplitVerse(scripture);

        while(input != "quit")
        {
            Console.Write("Press enter to display verse or type quit ");
            input = Console.ReadLine();
            Display(scripture, combinedRef);
        }
    }


    public static Reference GetRefFromUser()
    {
        Reference r1;

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
        return r1;
    }
    public static string GetScriptureFromUser()
    {
        Console.Write("Enter a scripture: ");
        return Console.ReadLine();
    }

    public static void Display(string scripture, string reference)
    {
        w1.PickWords();
        Console.Clear();
        Console.WriteLine(reference);
        Console.WriteLine(w1.JoinVerse());
    }
}

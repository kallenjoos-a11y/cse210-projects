class Program
{
    static Word w1;
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

        s1.SplitVerse(scripture);

        w1 = new Word(s1.GetSplitScripLen());

        while(input != "quit")
        {
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
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
        w1.PickWords(s1);
        Console.Clear();
        Console.WriteLine(reference);
        Console.WriteLine(s1.JoinVerse());
    }
}

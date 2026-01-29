namespace Develop02;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Journal Program!");

        Entry entry1 = new Entry();
        entry1._userInput = 0;

         while(entry1._userInput != 5)
        {
            entry1.EntrySelection();
            entry1.PromptManager();
        }
    }
}
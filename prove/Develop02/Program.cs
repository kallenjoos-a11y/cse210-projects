namespace Develop02;
using System.IO;
class Program
{
    private static Random random = new Random();
    private static Journal journal = new Journal();
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Journal Program!");

        int userInput = 0;

         while(userInput != 5)
        {
            userInput = EntrySelection();

            if(userInput == 1)
            {
                Write();
            } 
            else if(userInput == 2)
            {
                Display();
            }
            else if (userInput == 3)
            {
                Load();
            }
            else if (userInput == 4)
            {
                Save();
            }
        }
    }

    static int EntrySelection(){
        Console.WriteLine("Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        Console.Write("What would you like to do? ");

        int userInput = 0; 
        while(!int.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Please enter a number from 1-5.");
        }
        
        return userInput;
    } 

    static void Write()
    {
        journal.Add(CreateNewEntry());
    }

    static void Display()
    {
        Console.WriteLine(journal);
    }

    static void Load()
    {
        Console.Write("Please enter the text file where you stored the code at: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
    }

    static void Save()
    {
        Console.Write("Please enter the text file where you'd like to store the code at: ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
    }    

    private static string PromptForPhotoPath()
    {
        Console.WriteLine("Please provide the file path to the picture you would like to add!");
        Console.Write("> ");
        string photo = Console.ReadLine();

        return photo;
    }
    private static string RandomPrompt()
    {
        List<string> promptList = new List<string>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        int randomIndex = random.Next(promptList.Count);

        string prompt = promptList[randomIndex];

        return prompt;
    }

    private static Entry CreateNewEntry()
    {
        string prompt = RandomPrompt();
        DateTime date = DateTime.Now;

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Console.Write("Would you like to add a photo? (y/n) ");
        string addPhoto = Console.ReadLine();
        
        string photoPath = null;
        if(addPhoto.ToLower() == "y" || addPhoto.ToLower() == "yes")
        {
            photoPath = PromptForPhotoPath();
        }
    
        Entry entry = new Entry{Response = response, Date = date, PhotoPath = photoPath, Prompt = prompt};
        
        return entry;
    }
}
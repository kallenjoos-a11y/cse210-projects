namespace Develop02;
using System.IO;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    Random random = new Random();


    public void RandomPrompt(Entry entry)
    {
        string prompt1 = "Who was the most interesting person I interacted with today?";
        string prompt2 = "What was the best part of my day?";
        string prompt3 = "How did I see the hand of the Lord in my life today?";
        string prompt4 = "What was the strongest emotion I felt today?";
        string prompt5 = "If I had one thing I could do over today, what would it be?";

        List<string> promptList = new List<string>{prompt1, prompt2, prompt3, prompt4, prompt5};

        int randomIndex = random.Next(promptList.Count);

        entry._prompt = promptList[randomIndex];
    }

    public void Date(Entry entry)
    {
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
    }

    public void Write()
    {
        Entry entry = new Entry();

        RandomPrompt(entry);
        Date(entry);

        Console.WriteLine(entry._prompt);
        Console.Write("> ");
        entry._response = Console.ReadLine();

        Console.Write("Would you like to add a photo? (y/n) ");
        string addPhoto = Console.ReadLine();
        
        if(addPhoto == "y")
        {
            Photo(entry);
        }
        else
        {
            entry._photo = "not given";
        }
    
        _entryList.Add(entry);
    }

    public void Photo(Entry entry)
    {
        Console.WriteLine("Please provide the file path to the picture you would like to add!");
        Console.Write("> ");
        entry._photo = Console.ReadLine();
    }

    public void Display()
    {
        foreach (Entry e in _entryList)
            {
                Console.WriteLine($"Date: {e._date} \nEntry: {e._response} \nImage: {e._photo}");
            }
    }

    public void Load()
    {
        Console.Write("Please enter the text file where you stored the code at: ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void Save()
    {
        Console.Write("Please enter the text file where you'd like to store the code at: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entryList)
            {
                outputFile.WriteLine($"Date: {e._date} \nEntry: {e._response} \nImage: {e._photo}");
            }
            
        }
    }    
}

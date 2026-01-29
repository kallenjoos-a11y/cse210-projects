namespace Develop02;

public class Journal
{
    public string _response;
    public string _prompt;
    public string _date;
    public List<string> _entryList = new List<string>();


    public void RandomPrompt()
    {
        string prompt1 = "Who was the most interesting person I interacted with today?";
        string prompt2 = "What was the best part of my day?";
        string prompt3 = "How did I see the hand of the Lord in my life today?";
        string prompt4 = "What was the strongest emotion I felt today?";
        string prompt5 = "If I had one thing I could do over today, what would it be?";

        List<string> promptList = new List<string>{prompt1, prompt2, prompt3, prompt4, prompt5};

        Random random = new Random();

        int randomIndex = random.Next(promptList.Count);

        _prompt = promptList[randomIndex];
    }

    public void Date()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

    }
    public void Write()
    {
        RandomPrompt();
        Date();
        
        Console.WriteLine($"This is prompt: {_prompt}");
        Console.Write("> ");
        _response = Console.ReadLine();

        _entryList.Add(_response);
    }

    public void Display()
    {
        
    }
}

public class Reflect : Activity
{
    private static List<string> _prompt;
    private static List<string> _followUp;
    private Random _random;

    static Reflect() {
        _prompt = new List<string>();
        _followUp = new List<string>();
        
        _prompt.AddRange("Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.");
        _followUp.AddRange("Why was this experience meaningful to you?",                        
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",            "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",                
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?");
    }

    public Reflect(int actDuration) : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", actDuration, "reflect")
    {
        _random = new Random();
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Think about this prompt and press enter when you're ready: ");
        Console.WriteLine(GetInitPrompt());
        Console.ReadLine();
        Console.WriteLine($"You will now see follow-up prompts. Reflect on each one for the next {_actDuration} seconds.");
    }


    public override void EndActivity()
    {
        Console.WriteLine("\nTime is up! Thank you for reflecting.");
        base.EndActivity();
    }

    public override DateTime Run()
    {
        string followUp = GetFollowUpPrompt();
        Console.Write($"{followUp} ");
        Animate();

        return DateTime.Now;
    }

    public string GetInitPrompt()
    {
        int randInt = _random.Next(_prompt.Count);
        return _prompt[randInt];
    }

    public string GetFollowUpPrompt()
    {
        int randInt = _random.Next(_followUp.Count);
        return _followUp[randInt];
    }
}
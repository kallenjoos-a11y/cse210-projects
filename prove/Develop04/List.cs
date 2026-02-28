public class Lists : Activity
{
    private static List<string> _prompt;
    private int _countInput;
    private Random _random;

    static Lists()
    {
        _prompt = new List<string>{"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    }

    public Lists(int actDuration) : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", actDuration, "list")
    {
        _countInput = 0;
        _random = new Random();
    }

    public string GetPrompt()
    {
        int randInt = _random.Next(_prompt.Count);
        return _prompt[randInt];
    }

    public override DateTime Run()
    {
        Console.Write("> ");
        Console.ReadLine();
        _countInput++;
        return DateTime.Now;
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("Write as many responses as you can to the following prompt: ");
        Console.WriteLine($"-------------- {GetPrompt()}  --------------");
    }

    public override void EndActivity()
    {
        Console.WriteLine($"You wrote {_countInput} responses!");
        base.EndActivity();
    }
}
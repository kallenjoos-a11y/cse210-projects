public class Breathe : Activity
{
    public Breathe(int actDuration) : base("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", actDuration, "breathe")
    {}

    public override DateTime Run()
    {
        Console.Clear();
            Console.WriteLine("Breathe in through your nose... ");
            Console.Write("||||||||||||||||||||||||||||||||||||||||||||||||||");
            
            for(int i = 0; i < 50; i++){
                Thread.Sleep(100);
                Console.Write("\b \b");
            }

            Console.Clear();
            Console.WriteLine("Exhale out your mouth... ");
            Console.Write("||||||||||||||||||||||||||||||||||||||||||||||||||");
            
            for(int i = 0; i < 50; i++){
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
            return DateTime.Now;
    }
}
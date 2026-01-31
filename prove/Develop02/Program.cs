namespace Develop02;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Journal Program!");

        int userInput = 0;

        Journal journal = new Journal();

         while(userInput != 5)
        {
            EntrySelection();

            if(userInput == 1)
            {
                journal.Write();
            } 
            else if(userInput == 2)
            {
                journal.Display();
            }
            else if (userInput == 3)
            {
                journal.Load();
            }
            else if (userInput == 4)
            {
                journal.Save();
            }
        }

        void EntrySelection(){
        Console.WriteLine("Please select one of the following choices: \n1.Write \n2. Display \n3.Load \n4. Save \n5. Quit");
        Console.Write("What would you like to do? ");

        userInput = int.Parse(Console.ReadLine());
    } 
    }
}
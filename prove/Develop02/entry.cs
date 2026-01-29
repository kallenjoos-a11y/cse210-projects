using System.Threading.Tasks.Dataflow;

namespace Develop02;

public class Entry
{
    public int _userInput;

    public void EntrySelection(){
        Console.WriteLine("Please select one of the following choices: \n1.Write \n2. Display \n3.Load \n4. Save \n5. Quit");
        Console.Write("What would you like to do? ");

        _userInput = int.Parse(Console.ReadLine());
        Console.WriteLine(_userInput);
    } 


    public void PromptManager()
    {
        Journal journal = new Journal(); 
        if(_userInput == 1)
        {
            journal.Write();
        } 
        else if(_userInput == 2)
        {
            journal.Display();
        }
    }
}
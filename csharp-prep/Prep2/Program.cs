using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you receive? ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);
        string gradeReceived = "";
        bool pass = false;
        string minusPlusDeterminer = "";

        if (grade % 10 < 3 && grade >= 70)
        {
            minusPlusDeterminer = "-";
        } 
        else if (grade % 10 <= 7 && grade <= 90 && grade >=70)
        {
            minusPlusDeterminer = "+";
        }
        else
        {
            minusPlusDeterminer = "";
        }

        if (grade >= 90)
        {
            gradeReceived = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            gradeReceived = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            gradeReceived = "C";
            pass = true;
        }
        else
        {
            gradeReceived = "F";
            pass = false;
        }

        Console.WriteLine($"You received a(n) {gradeReceived}{minusPlusDeterminer}.");

        if (pass == true)
        {
            Console.WriteLine("Congrats!! You passed the class.");
        }
        else
        {
            Console.Write("Sorry. You didn't pass the class. Would you like to take it again? (True/False) ");
            string userInput = Console.ReadLine();

            bool takeClassAgain = bool.Parse(userInput);

            if (takeClassAgain == true)
            {
                Console.WriteLine("Okay! To register, call into our help desk at 000-000-0000. Thank you!");
            }  
            else
            {
                Console.WriteLine("Okay! We hope you success in all your pursuits.");
            }

        }
    }
}
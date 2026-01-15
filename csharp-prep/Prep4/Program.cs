using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int userNum;
        int totalSum = 0;
        int highestNum = 0;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();

            userNum = int.Parse(userInput);
            numbers.Add(userNum);
        }
        while(userNum != 0);
            
        for (int i = 0; i < numbers.Count; ++i)
        {
            totalSum += numbers[i];

            if(numbers[i] > highestNum)
            {
                highestNum = numbers[i];
            }
        }

        Console.WriteLine($"The total sum is: {totalSum}");
        Console.WriteLine($"The average is: {totalSum /(numbers.Count - 1)}");
        Console.WriteLine($"The largest number is: {highestNum}");
    }
}
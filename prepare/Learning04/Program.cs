using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jeremy James", "PE");
        Console.WriteLine(a1.GetSummary());
        MathAssignment m1 = new MathAssignment("Problems 5-13", "Section 5.6", "James Jonathan", "Bio-science");
        Console.WriteLine(m1.GetHomeworkList());
        WritingAssignment w1 = new WritingAssignment("The big adventures of hullabaloo", "John Jacob", "Korean literature");
        Console.WriteLine(w1.GetWritingInformation());
    }
}
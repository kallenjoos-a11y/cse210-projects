using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Random random = new Random();
        Fraction f4 = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            int top = random.Next(1, 11);
            int bottom = random.Next(1, 11);

            f4.SetTop(top);
            f4.SetBottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {f4.GetFractionString()} Number: {f4.GetDecimalValue()}");
        }
    }
}
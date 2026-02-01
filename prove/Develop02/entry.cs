using System;

namespace Develop02;

public class Entry
{
    public string Response { get; init; }
    public string Prompt { get; init; }
    public DateTime Date { get; init; }
    public string PhotoPath { get; init; } 

    public override string ToString()
    {
        return $"Date: {Date.ToShortDateString()}\n Prompt Given: {Prompt} \nEntry: {Response} \nImage: {PhotoPath ?? "Not Given"}";
    }

    public string ToCSV()
    {
       return $"{Response},{Prompt},{Date},{PhotoPath}";
    }
    public static Entry CreateFromCSV(string csv)
    {
        string[] parts = csv.Split(",");
        string response = parts[0];
        string prompt = parts[1];
        DateTime.TryParse(parts[2], out DateTime date);
        string photoPath = parts[3];
    
        Entry entry = new Entry{Response = response, Date = date, PhotoPath = photoPath, Prompt = prompt};
        
        return entry;
    }
}
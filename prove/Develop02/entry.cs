using System;

namespace Develop02;

public class Entry
{
    public string _response;
    public string _prompt;
    public DateTime _date;
    public string _photoPath;

    public override string ToString()
    {
        return $"Date: {_date.ToShortDateString()}\n Prompt Given: {_prompt} \nEntry: {_response} \nImage: {_photoPath ?? "Not Given"}";
    }

    public string ToCSV()
    {
       return $"{_response},{_prompt},{_date},{_photoPath}";
    }
    public static Entry CreateFromCSV(string csv)
    {
        string[] parts = csv.Split(",");
        string response = parts[0];
        string prompt = parts[1];
        DateTime.TryParse(parts[2], out DateTime date);
        string photoPath = parts[3];
    
        Entry entry = new Entry{_response = response, _date = date, _photoPath = photoPath, _prompt = prompt};
        
        return entry;
    }
}
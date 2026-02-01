namespace Develop02;
using System.IO;

public class Journal
{
    private List<Entry> _entryList = new List<Entry>();

    public void Add(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        { 
            foreach (Entry e in _entryList)
            {
                outputFile.WriteLine(e.ToCSV());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entryList.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            _entryList.Add(Entry.CreateFromCSV(line));
        }
    }

    public override string ToString()
    {
        string output = "";
        foreach (Entry e in _entryList)
        {
            output += e.ToString();
            output += "\n-----------------------------------------\n";
        }
        return output;
    }
}

class Scripture
{
    private string _scripture;
    private string[] _splitScrip;

    public string GetScripture()
    {
        return _scripture;
    }

    public Scripture(string scripture) {
        _scripture = scripture;
    }

    public Scripture() {
    }

    public void SplitVerse(string verse)
    {
        _splitScrip = verse.Split(" ");
    }

    public string JoinVerse()
    {
        return String.Join(" ", _splitScrip);
    }

    public int GetSplitScripLen()
    {
        return _splitScrip.Length;
    }

    public int GetWordLen(int rand)
    {
        return _splitScrip[rand].Length;
    }

    public void SetWord(string newName, int index)
    {
        _splitScrip[index] = newName;
    }
}
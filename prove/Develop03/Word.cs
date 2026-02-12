class Word
{
    private string[] _word;
    private bool _hidden; 

    //public string GetWord() {}
    //public void HideWord() {}

    public void SplitVerse(string verse)
    {
        _word = verse.Split(" ");
    }

    public string JoinVerse()
    {
        return String.Join(" ", _word);
    }
}
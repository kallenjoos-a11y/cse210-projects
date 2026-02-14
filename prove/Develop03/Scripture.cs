class Scripture
{
    private string _scripture;

    public void Display()
    {
        //_scripture = JoinVerse();
        Console.WriteLine("");
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public Scripture(string scripture) {
        _scripture = scripture;
    }

}
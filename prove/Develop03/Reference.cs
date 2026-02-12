class Reference
{
    private string _book;
    private string _chap;
    private string _firstVerse;
    private string _lastVerse;

    //public string GetRef()
    //{
    
    //}

    public string CombineReference()
    {
        if(_lastVerse == null)
        {
            return $"{_book} {_chap}:{_firstVerse}";
        } else
        {
             return $"{_book} {_chap}:{_firstVerse}-{_lastVerse}";
        }    
    }

    public Reference(string book, string chap, string fVerse, string lVerse)
    {
        _book = book;
        _chap = chap;
        _firstVerse = fVerse;
        _lastVerse = lVerse;
    }

    public Reference(string book, string chap, string fVerse)
    {
        _book = book;
        _chap = chap;
        _firstVerse = fVerse;

    }
}
using System.Runtime.InteropServices;

class Word
{
    private string[] _word;
    private bool[] _hidden; 
    private Random _rand = new Random();

    //public string GetWord() {}

    public void SplitVerse(string verse)
    {
        _word = verse.Split(" ");
        _hidden = new bool[_word.Length];
    }

    public string JoinVerse()
    {
        return String.Join(" ", _word);
    }

    public void PickWords()
    {
        if (_hidden.Contains(false))
        {
            if(_hidden.Count(x => !x) < 3)
            {
                HideWord(_hidden.Count(x => !x));
            } else
            {
                HideWord(3);
            }
        } else
        {
            System.Environment.Exit(0);
        }
    }

    public void HideWord(int wordHide)
    {
        for(int i = 0; i < wordHide; i++){
            int randomIndex = _rand.Next(_word.Length);
            if(!_hidden[randomIndex]){
                _word[randomIndex] = FindWordLength(_word[randomIndex].Length);
                _hidden[randomIndex] = true;
            } else
            {
                i--;
            }
        }
    }

    public string FindWordLength(int length)
    {
        string word = "";

        for(int i = 0; i < length; i++)
        {
            word += "_";
        }
        return word;
    }
}
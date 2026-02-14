using System.Runtime.InteropServices;

class Word
{
    private bool[] _hidden; 
    private Random _rand;

    public Word(int length){
        _hidden = new bool[length];
        _rand = new Random();
    }

    public void PickWords(Scripture s1)
    {
        if (_hidden.Contains(false))
        {
            int remaining = _hidden.Count(x => !x);
            if(remaining < 3)
            {
                HideWord(s1, remaining);
            } else
            {
                HideWord(s1, 3);
            }
        } else
        {
            System.Environment.Exit(0);
        }
    }

    public void HideWord(Scripture s1, int wordHide)
    {
        for(int i = 0; i < wordHide; i++){
            int randomIndex = _rand.Next(_hidden.Length);

            while(_hidden[randomIndex]){
                randomIndex = _rand.Next(_hidden.Length);
            } 
            int wordLength = s1.GetWordLen(randomIndex);
            s1.SetWord(MakeReplacementHyphens(wordLength), randomIndex);
            _hidden[randomIndex] = true;
        }
    }

    public string MakeReplacementHyphens(int length)
    {
        string word = "";

        for(int i = 0; i < length; i++)
        {
            word += "_";
        }
        return word;
    }
}
class Scripture
{
    private Reference _reference;
    private List<Word> _text;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Display the scripture with hidden words
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (var word in _text)
        {
            Console.Write(word.DisplayWord() + " ");
        }
        Console.WriteLine();  // Add a line break for better readability
    }

    //Hide random words, ensuring it doesn't hide more than the remaining visible words
    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = 3;  //Number of words to hide at a time

        //Get the list of words that are still visible
        List<Word> visibleWords = _text.Where(word => !word._isHidden).ToList();
        
        //Hide a number of words, up to the number of visible words
        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            Word wordToHide = visibleWords[rand.Next(visibleWords.Count)];
            wordToHide.HideWord();
            visibleWords.Remove(wordToHide);  //Remove the hidden word from the visible list
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _text.All(word => word._isHidden);
    }
}
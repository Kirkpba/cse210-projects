class Word
{
    private string _text; //The text of the words
    public bool _isHidden {get; private set;} // Bool to track if we hid the word or not.
    //Not initially private but set to private but can be obtained by get which is used in the Scrupture class.

    //Constructor.
    public Word(string text)
    {
        _text = text;
        _isHidden = false; //We see all the words at first.
    }

    // Hide the word by changing the bool to true
    public void HideWord()
    {
        _isHidden = true;
    }

    // Display the words wheather they are hidden or visible.
    public string DisplayWord()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
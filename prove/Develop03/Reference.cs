class Reference
{
    private string _book; //The book from the Bible.
    private int _chapter; //The chapter #.
    private int _verseStart; //The starting verse #.
    private int? _verseEnd; // The ending verse # set to nullable if only one verse.

    //Constructor to initialize the reference for book, chapter, and the starting and ending verses.
    //This one constructor can handle a single verse or multiple saving lines of code to make a new
    //constructor altogether.
    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = null;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    //Retirns the refernce as a string.
    public string GetReference()
    {
        if (_verseEnd.HasValue)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd.Value}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
    }
}
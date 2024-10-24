class ScriptureLibrary
{
    private List<Scripture> _scriptures;  //Private list to store scriptures

    //Constructor to initialize the list of scriptures
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "\"Trust in the Lord with all thine heart; and lean not unto thine own understanding.\""),
            new Scripture(new Reference("Genesis", 1, 1), "\"In the beginning God created the heavens and the earth.\""),
            new Scripture(new Reference("Moses", 1, 39), "\"For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.\""),
            new Scripture(new Reference("Galatians", 5, 22, 23), "\"But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, Meekness, temperance: against such there is no law.\"")
            //Add more scriptures here if you want to have more to memorize TA. ;)
        };
    }

    //Method to select and return a random scripture from the list
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];  //Return a random scripture
    }
}
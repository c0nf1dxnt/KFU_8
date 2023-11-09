namespace Part1
{
    class Song
    {
        public string name { get; set; }
        public string author { get; set; }
        public Song previousSong { get; set; }
        public Song(string Name, string Author, Song PreviousSong)
        {
            name = Name;
            author = Author;
            previousSong = PreviousSong;
        }
        public Song(string Name, string Author)
        {
            name = Name;
            author = Author;
            previousSong = null;
        }
        public Song()
        {
            name = "unknown";
            author = "unknown";
            previousSong = null;
        }
        public string Title()
        {
            return $"{name} - {author}";
        }
        public bool CheckForSimilarity(Song comparableSong)
        {
            return name == comparableSong.name && author == comparableSong.author;
        }
    }
}

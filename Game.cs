namespace Modul10_103022400142
{
    public class Game
    {
       public int Id { get; set; }
       public string Name { get; set; }
        public string Developer { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public List<string> Platforms { get; set; }
        public List<string> Modes { get; set; }
        public bool isOnline { get; set; }
        public int Harga { get; set; }

        public Game(int id, string name, string developer, int releaseYear, string genre, double rating, List<string> platforms, List<string> modes, bool isOnline, int harga)
        {
            Id = id;
            Name = name;
            Developer = developer;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            Platforms = platforms;
            Modes = modes;
            this.isOnline = isOnline;
            Harga = harga;
        }
        public Game()
        {
        }
    }
}

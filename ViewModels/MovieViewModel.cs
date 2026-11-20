namespace Day6_LaVanHien.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public int GenreId { get; set; }
        public string? GenreName { get; set; }

    }
}

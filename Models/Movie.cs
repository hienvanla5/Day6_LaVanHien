using System.ComponentModel.DataAnnotations;

namespace Day6_LaVanHien.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}

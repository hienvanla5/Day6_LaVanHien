using System.ComponentModel.DataAnnotations;

namespace Day6_LaVanHien.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
